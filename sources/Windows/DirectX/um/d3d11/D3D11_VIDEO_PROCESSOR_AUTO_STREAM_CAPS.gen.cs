﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DENOISE"]/*' />
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DENOISE = 0x1,

    /// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DERINGING"]/*' />
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DERINGING = 0x2,

    /// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_EDGE_ENHANCEMENT"]/*' />
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_EDGE_ENHANCEMENT = 0x4,

    /// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_COLOR_CORRECTION"]/*' />
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_COLOR_CORRECTION = 0x8,

    /// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_FLESH_TONE_MAPPING"]/*' />
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_FLESH_TONE_MAPPING = 0x10,

    /// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_IMAGE_STABILIZATION"]/*' />
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_IMAGE_STABILIZATION = 0x20,

    /// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_SUPER_RESOLUTION"]/*' />
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_SUPER_RESOLUTION = 0x40,

    /// <include file='D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS.D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_ANAMORPHIC_SCALING"]/*' />
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_ANAMORPHIC_SCALING = 0x80,
}
