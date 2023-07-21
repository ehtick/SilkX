﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_POINTDIFFUSE_SCALE_MODE.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_SCALE_MODE"]/*' />
public enum D2D1_POINTDIFFUSE_SCALE_MODE
{
    /// <include file='D2D1_POINTDIFFUSE_SCALE_MODE.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_SCALE_MODE.D2D1_POINTDIFFUSE_SCALE_MODE_NEAREST_NEIGHBOR"]/*' />
    D2D1_POINTDIFFUSE_SCALE_MODE_NEAREST_NEIGHBOR = 0,

    /// <include file='D2D1_POINTDIFFUSE_SCALE_MODE.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_SCALE_MODE.D2D1_POINTDIFFUSE_SCALE_MODE_LINEAR"]/*' />
    D2D1_POINTDIFFUSE_SCALE_MODE_LINEAR = 1,

    /// <include file='D2D1_POINTDIFFUSE_SCALE_MODE.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_SCALE_MODE.D2D1_POINTDIFFUSE_SCALE_MODE_CUBIC"]/*' />
    D2D1_POINTDIFFUSE_SCALE_MODE_CUBIC = 2,

    /// <include file='D2D1_POINTDIFFUSE_SCALE_MODE.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_SCALE_MODE.D2D1_POINTDIFFUSE_SCALE_MODE_MULTI_SAMPLE_LINEAR"]/*' />
    D2D1_POINTDIFFUSE_SCALE_MODE_MULTI_SAMPLE_LINEAR = 3,

    /// <include file='D2D1_POINTDIFFUSE_SCALE_MODE.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_SCALE_MODE.D2D1_POINTDIFFUSE_SCALE_MODE_ANISOTROPIC"]/*' />
    D2D1_POINTDIFFUSE_SCALE_MODE_ANISOTROPIC = 4,

    /// <include file='D2D1_POINTDIFFUSE_SCALE_MODE.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_SCALE_MODE.D2D1_POINTDIFFUSE_SCALE_MODE_HIGH_QUALITY_CUBIC"]/*' />
    D2D1_POINTDIFFUSE_SCALE_MODE_HIGH_QUALITY_CUBIC = 5,

    /// <include file='D2D1_POINTDIFFUSE_SCALE_MODE.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_SCALE_MODE.D2D1_POINTDIFFUSE_SCALE_MODE_FORCE_DWORD"]/*' />
    D2D1_POINTDIFFUSE_SCALE_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
