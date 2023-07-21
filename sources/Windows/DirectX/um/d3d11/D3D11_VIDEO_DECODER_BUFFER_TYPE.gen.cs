﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_DECODER_BUFFER_TYPE
{
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS = 0,

    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL = 1,

    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE = 2,

    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL = 3,

    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX = 4,

    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL = 5,

    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_BITSTREAM"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_BITSTREAM = 6,

    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR = 7,

    /// <include file='D3D11_VIDEO_DECODER_BUFFER_TYPE.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_TYPE.D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN"]/*' />
    D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN = 8,
}
