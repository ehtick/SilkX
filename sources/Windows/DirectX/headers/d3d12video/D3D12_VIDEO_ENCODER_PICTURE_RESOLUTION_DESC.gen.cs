﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC"]/*' />
public partial struct D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC.Width"]/*' />
    public uint Width;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC.Height"]/*' />
    public uint Height;
}
