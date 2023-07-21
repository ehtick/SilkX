﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP"]/*' />
public enum D2D1_CONVOLVEMATRIX_PROP
{
    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_KERNEL_UNIT_LENGTH"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_UNIT_LENGTH = 0,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_SCALE_MODE"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_SCALE_MODE = 1,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_X"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_X = 2,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_Y"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_Y = 3,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_KERNEL_MATRIX"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_MATRIX = 4,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_DIVISOR"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_DIVISOR = 5,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_BIAS"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_BIAS = 6,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_KERNEL_OFFSET"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_OFFSET = 7,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_PRESERVE_ALPHA"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_PRESERVE_ALPHA = 8,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_BORDER_MODE"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_BORDER_MODE = 9,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_CLAMP_OUTPUT"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_CLAMP_OUTPUT = 10,

    /// <include file='D2D1_CONVOLVEMATRIX_PROP.xml' path='doc/member[@name="D2D1_CONVOLVEMATRIX_PROP.D2D1_CONVOLVEMATRIX_PROP_FORCE_DWORD"]/*' />
    D2D1_CONVOLVEMATRIX_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
