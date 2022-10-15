// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX
{
    [Flags]
    internal enum D3D12_FORMAT_SUPPORT1
    {
        D3D12_FORMAT_SUPPORT1_NONE = 0,
        D3D12_FORMAT_SUPPORT1_BUFFER = 0x1,
        D3D12_FORMAT_SUPPORT1_IA_VERTEX_BUFFER = 0x2,
        D3D12_FORMAT_SUPPORT1_IA_INDEX_BUFFER = 0x4,
        D3D12_FORMAT_SUPPORT1_SO_BUFFER = 0x8,
        D3D12_FORMAT_SUPPORT1_TEXTURE1D = 0x10,
        D3D12_FORMAT_SUPPORT1_TEXTURE2D = 0x20,
        D3D12_FORMAT_SUPPORT1_TEXTURE3D = 0x40,
        D3D12_FORMAT_SUPPORT1_TEXTURECUBE = 0x80,
        D3D12_FORMAT_SUPPORT1_SHADER_LOAD = 0x100,
        D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE = 0x200,
        D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_COMPARISON = 0x400,
        D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_MONO_TEXT = 0x800,
        D3D12_FORMAT_SUPPORT1_MIP = 0x1000,
        D3D12_FORMAT_SUPPORT1_RENDER_TARGET = 0x4000,
        D3D12_FORMAT_SUPPORT1_BLENDABLE = 0x8000,
        D3D12_FORMAT_SUPPORT1_DEPTH_STENCIL = 0x10000,
        D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RESOLVE = 0x40000,
        D3D12_FORMAT_SUPPORT1_DISPLAY = 0x80000,
        D3D12_FORMAT_SUPPORT1_CAST_WITHIN_BIT_LAYOUT = 0x100000,
        D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RENDERTARGET = 0x200000,
        D3D12_FORMAT_SUPPORT1_MULTISAMPLE_LOAD = 0x400000,
        D3D12_FORMAT_SUPPORT1_SHADER_GATHER = 0x800000,
        D3D12_FORMAT_SUPPORT1_BACK_BUFFER_CAST = 0x1000000,
        D3D12_FORMAT_SUPPORT1_TYPED_UNORDERED_ACCESS_VIEW = 0x2000000,
        D3D12_FORMAT_SUPPORT1_SHADER_GATHER_COMPARISON = 0x4000000,
        D3D12_FORMAT_SUPPORT1_DECODER_OUTPUT = 0x8000000,
        D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_OUTPUT = 0x10000000,
        D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_INPUT = 0x20000000,
        D3D12_FORMAT_SUPPORT1_VIDEO_ENCODER = 0x40000000,
    }
}