﻿#if WINDOWS_UWP
using System.Runtime.InteropServices;
using ComputeSharp.Uwp.Helpers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TerraFX.Interop.Windows;
#else
using ComputeSharp.WinUI.Helpers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using TerraFX.Interop.Windows;
using WinRT;
#endif

#if WINDOWS_UWP
namespace ComputeSharp.Uwp;
#else
namespace ComputeSharp.WinUI;
#endif

/// <summary>
/// <para>
/// A custom <see cref="SwapChainPanel"/> that can be used to render animated backgrounds.
/// It is powered by ComputeSharp and leverages compute shaders to create frames to display.
/// </para>
/// <para>
/// This panel will always render new frames at the current display refresh rate, automatically.
/// </para>
/// </summary>
public sealed partial class AnimatedComputeShaderPanel : SwapChainPanel
{
    /// <summary>
    /// The <see cref="SwapChainManager"/> instance handling rendering.
    /// </summary>
    private readonly SwapChainManager swapChainManager;

    /// <summary>
    /// Creates a new <see cref="AnimatedComputeShaderPanel"/> instance.
    /// </summary>
    public unsafe AnimatedComputeShaderPanel()
    {
#if WINDOWS_UWP
        IUnknown* swapChainPanel = (IUnknown*)Marshal.GetIUnknownForObject(this);
#else
        IUnknown* swapChainPanel = (IUnknown*)((IWinRTObject)this).NativeObject.ThisPtr;
#endif

        this.swapChainManager = new SwapChainManager(swapChainPanel);

        this.Loaded += AnimatedComputeShaderPanel_Loaded;
        this.Unloaded += AnimatedComputeShaderPanel_Unloaded;
        this.SizeChanged += AnimatedComputeShaderPanel_SizeChanged;
        this.CompositionScaleChanged += AnimatedComputeShaderPanel_CompositionScaleChanged;
    }

    // Initializes the swap chain and starts the render thread
    private void AnimatedComputeShaderPanel_Loaded(object sender, RoutedEventArgs e)
    {
        this.swapChainManager.QueueResize(ActualWidth, ActualHeight);
        this.swapChainManager.QueueCompositionScaleChange(CompositionScaleX, CompositionScaleY);
        this.swapChainManager.QueueResolutionScaleChange(ResolutionScale);
        this.swapChainManager.QueueDynamicResolutionModeChange(IsDynamicResolutionEnabled);

        if (!IsPaused &&
            ShaderRunner is IShaderRunner shaderRunner)
        {
            this.swapChainManager.StartRenderLoop(null, shaderRunner);
        }
    }

    // Requests a cancellation for the render thread
    private void AnimatedComputeShaderPanel_Unloaded(object sender, RoutedEventArgs e)
    {
        this.swapChainManager.StopRenderLoop();
    }

    // Updates the background store for the frame size factors used by the render thread
    private void AnimatedComputeShaderPanel_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        this.swapChainManager.QueueResize(e.NewSize.Width, e.NewSize.Height);
    }

    // Updates the background store for the composition scale factors used by the render thread
    private void AnimatedComputeShaderPanel_CompositionScaleChanged(SwapChainPanel sender, object args)
    {
        this.swapChainManager.QueueCompositionScaleChange(CompositionScaleX, CompositionScaleY);
    }
}
