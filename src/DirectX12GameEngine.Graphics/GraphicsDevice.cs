﻿using System;
using System.Threading;
using SharpDX.Direct3D;
using SharpDX.Direct3D12;

namespace DirectX12GameEngine.Graphics
{
    public sealed class GraphicsDevice : IDisposable
    {
        private readonly AutoResetEvent fenceEvent = new AutoResetEvent(false);
        private SharpDX.Direct3D11.Device? nativeDirect3D11Device;

        public GraphicsDevice(FeatureLevel minFeatureLevel = FeatureLevel.Level_11_0, bool enableDebugLayer = false)
        {
#if DEBUG
            if (enableDebugLayer)
            {
                DebugInterface.Get().EnableDebugLayer();
            }
#endif
            FeatureLevel = minFeatureLevel < FeatureLevel.Level_11_0 ? FeatureLevel.Level_11_0 : minFeatureLevel;

            NativeDevice = new Device(null, FeatureLevel);

            NativeComputeCommandQueue = NativeDevice.CreateCommandQueue(new CommandQueueDescription(SharpDX.Direct3D12.CommandListType.Compute));
            NativeCopyCommandQueue = NativeDevice.CreateCommandQueue(new CommandQueueDescription(SharpDX.Direct3D12.CommandListType.Copy));
            NativeDirectCommandQueue = NativeDevice.CreateCommandQueue(new CommandQueueDescription(SharpDX.Direct3D12.CommandListType.Direct));

            BundleAllocatorPool = new CommandAllocatorPool(this, CommandListType.Bundle);
            ComputeAllocatorPool = new CommandAllocatorPool(this, CommandListType.Compute);
            CopyAllocatorPool = new CommandAllocatorPool(this, CommandListType.Copy);
            DirectAllocatorPool = new CommandAllocatorPool(this, CommandListType.Direct);

            NativeComputeFence = NativeDevice.CreateFence(0, FenceFlags.None);
            NativeCopyFence = NativeDevice.CreateFence(0, FenceFlags.None);
            NativeDirectFence = NativeDevice.CreateFence(0, FenceFlags.None);

            DepthStencilViewAllocator = new DescriptorAllocator(this, DescriptorHeapType.DepthStencilView, descriptorCount: 1);
            RenderTargetViewAllocator = new DescriptorAllocator(this, DescriptorHeapType.RenderTargetView, descriptorCount: 2);
            ShaderResourceViewAllocator = new DescriptorAllocator(this, DescriptorHeapType.ConstantBufferViewShaderResourceViewUnorderedAccessView, DescriptorHeapFlags.ShaderVisible);

            CommandList = new CommandList(this, CommandListType.Direct);
            CommandList.Close();

            CopyCommandList = new CommandList(this, CommandListType.Copy);
            CopyCommandList.Close();
        }

        public CommandList CommandList { get; }

        public CommandList CopyCommandList { get; }

        public FeatureLevel FeatureLevel { get; }

        internal Device NativeDevice { get; }

        internal SharpDX.Direct3D11.Device NativeDirect3D11Device => NativeDirect3D11Device ?? (nativeDirect3D11Device = SharpDX.Direct3D11.Device.CreateFromDirect3D12(
                NativeDevice, SharpDX.Direct3D11.DeviceCreationFlags.BgraSupport, null, null, NativeDirectCommandQueue));

        internal DescriptorAllocator DepthStencilViewAllocator { get; set; }

        internal DescriptorAllocator RenderTargetViewAllocator { get; set; }

        internal DescriptorAllocator ShaderResourceViewAllocator { get; set; }

        internal CommandAllocatorPool BundleAllocatorPool { get; }

        internal CommandAllocatorPool ComputeAllocatorPool { get; }

        internal CommandAllocatorPool CopyAllocatorPool { get; }

        internal CommandAllocatorPool DirectAllocatorPool { get; }

        internal CommandQueue NativeComputeCommandQueue { get; }

        internal CommandQueue NativeCopyCommandQueue { get; }

        internal CommandQueue NativeDirectCommandQueue { get; }

        internal Fence NativeComputeFence { get; }

        internal Fence NativeCopyFence { get; }

        internal Fence NativeDirectFence { get; }

        internal long NextComputeFenceValue { get; private set; } = 1;

        internal long NextCopyFenceValue { get; private set; } = 1;

        internal long NextDirectFenceValue { get; private set; } = 1;

        public RootSignature CreateRootSignature(RootSignatureDescription rootSignatureDescription)
        {
            return NativeDevice.CreateRootSignature(rootSignatureDescription.Serialize());
        }

        public void Dispose()
        {
            NativeDirectCommandQueue.Signal(NativeDirectFence, NextDirectFenceValue);
            NativeDirectCommandQueue.Wait(NativeDirectFence, NextDirectFenceValue);

            CommandList.Dispose();
            CopyCommandList.Dispose();

            DepthStencilViewAllocator.Dispose();
            RenderTargetViewAllocator.Dispose();
            ShaderResourceViewAllocator.Dispose();

            BundleAllocatorPool.Dispose();
            ComputeAllocatorPool.Dispose();
            CopyAllocatorPool.Dispose();
            DirectAllocatorPool.Dispose();

            NativeComputeCommandQueue.Dispose();
            NativeCopyCommandQueue.Dispose();
            NativeDirectCommandQueue.Dispose();

            NativeComputeFence.Dispose();
            NativeDirectFence.Dispose();
            NativeDirectFence.Dispose();

            nativeDirect3D11Device?.Dispose();

            NativeDevice.Dispose();
        }

        public void ExecuteCommandLists(bool wait, params CompiledCommandList[] commandLists)
        {
            Fence fence = commandLists[0].Builder.CommandListType switch
            {
                CommandListType.Direct => NativeDirectFence,
                CommandListType.Compute => NativeComputeFence,
                CommandListType.Copy => NativeCopyFence,
                _ => throw new NotSupportedException("This command list type is not supported.")
            };

            long fenceValue = ExecuteCommandLists(commandLists);

            if (wait)
            {
                WaitForFence(fence, fenceValue);
            }
        }

        public long ExecuteCommandLists(params CompiledCommandList[] commandLists)
        {
            CommandAllocatorPool commandAllocatorPool;
            CommandQueue commandQueue;
            Fence fence;
            long fenceValue;

            switch (commandLists[0].Builder.CommandListType)
            {
                case CommandListType.Compute:
                    commandAllocatorPool = ComputeAllocatorPool;
                    commandQueue = NativeComputeCommandQueue;

                    fence = NativeComputeFence;
                    fenceValue = NextComputeFenceValue;
                    NextDirectFenceValue++;
                    break;
                case CommandListType.Copy:
                    commandAllocatorPool = CopyAllocatorPool;
                    commandQueue = NativeCopyCommandQueue;

                    fence = NativeCopyFence;
                    fenceValue = NextCopyFenceValue;
                    NextCopyFenceValue++;
                    break;
                case CommandListType.Direct:
                    commandAllocatorPool = DirectAllocatorPool;
                    commandQueue = NativeDirectCommandQueue;

                    fence = NativeDirectFence;
                    fenceValue = NextDirectFenceValue;
                    NextDirectFenceValue++;
                    break;
                default:
                    throw new NotSupportedException("This command list type is not supported.");
            }

            SharpDX.Direct3D12.CommandList[] nativeCommandLists = new SharpDX.Direct3D12.CommandList[commandLists.Length];

            for (int i = 0; i < commandLists.Length; i++)
            {
                nativeCommandLists[i] = commandLists[i].NativeCommandList;
                commandAllocatorPool.Enqueue(commandLists[i].NativeCommandAllocator, fenceValue);
            }

            commandQueue.ExecuteCommandLists(nativeCommandLists);
            commandQueue.Signal(fence, fenceValue);

            return fenceValue;
        }

        internal bool IsFenceComplete(Fence fence, long fenceValue)
        {
            return fenceValue <= fence.CompletedValue;
        }

        internal void WaitForFence(Fence fence, long fenceValue)
        {
            if (IsFenceComplete(fence, fenceValue)) return;

            lock (fence)
            {
                fence.SetEventOnCompletion(fenceValue, fenceEvent.SafeWaitHandle.DangerousGetHandle());
                fenceEvent.WaitOne();
            }
        }
    }
}
