﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_CONTENT_PROTECTION_CAPS
{
    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_SOFTWARE"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_SOFTWARE = 0x1,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_HARDWARE"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_HARDWARE = 0x2,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_PROTECTION_ALWAYS_ON"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_PROTECTION_ALWAYS_ON = 0x4,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_PARTIAL_DECRYPTION"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_PARTIAL_DECRYPTION = 0x8,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_CONTENT_KEY"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_CONTENT_KEY = 0x10,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_FRESHEN_SESSION_KEY"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_FRESHEN_SESSION_KEY = 0x20,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK = 0x40,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK_KEY"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK_KEY = 0x80,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_SEQUENTIAL_CTR_IV"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_SEQUENTIAL_CTR_IV = 0x100,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_ENCRYPT_SLICEDATA_ONLY"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_ENCRYPT_SLICEDATA_ONLY = 0x200,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_DECRYPTION_BLT"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_DECRYPTION_BLT = 0x400,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECT_UNCOMPRESSED"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECT_UNCOMPRESSED = 0x800,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECTED_MEMORY_PAGEABLE"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECTED_MEMORY_PAGEABLE = 0x1000,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_TEARDOWN"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_TEARDOWN = 0x2000,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION = 0x4000,

    /// <include file='D3D11_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_CONTENT_PROTECTION_CAPS.D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION_MULTI_THREADED"]/*' />
    D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION_MULTI_THREADED = 0x8000,
}
