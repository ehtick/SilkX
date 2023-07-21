﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP"]/*' />
public enum D2D1_LINEARTRANSFER_PROP
{
    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_RED_Y_INTERCEPT"]/*' />
    D2D1_LINEARTRANSFER_PROP_RED_Y_INTERCEPT = 0,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_RED_SLOPE"]/*' />
    D2D1_LINEARTRANSFER_PROP_RED_SLOPE = 1,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_RED_DISABLE"]/*' />
    D2D1_LINEARTRANSFER_PROP_RED_DISABLE = 2,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_GREEN_Y_INTERCEPT"]/*' />
    D2D1_LINEARTRANSFER_PROP_GREEN_Y_INTERCEPT = 3,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_GREEN_SLOPE"]/*' />
    D2D1_LINEARTRANSFER_PROP_GREEN_SLOPE = 4,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_GREEN_DISABLE"]/*' />
    D2D1_LINEARTRANSFER_PROP_GREEN_DISABLE = 5,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_BLUE_Y_INTERCEPT"]/*' />
    D2D1_LINEARTRANSFER_PROP_BLUE_Y_INTERCEPT = 6,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_BLUE_SLOPE"]/*' />
    D2D1_LINEARTRANSFER_PROP_BLUE_SLOPE = 7,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_BLUE_DISABLE"]/*' />
    D2D1_LINEARTRANSFER_PROP_BLUE_DISABLE = 8,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_ALPHA_Y_INTERCEPT"]/*' />
    D2D1_LINEARTRANSFER_PROP_ALPHA_Y_INTERCEPT = 9,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_ALPHA_SLOPE"]/*' />
    D2D1_LINEARTRANSFER_PROP_ALPHA_SLOPE = 10,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_ALPHA_DISABLE"]/*' />
    D2D1_LINEARTRANSFER_PROP_ALPHA_DISABLE = 11,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_CLAMP_OUTPUT"]/*' />
    D2D1_LINEARTRANSFER_PROP_CLAMP_OUTPUT = 12,

    /// <include file='D2D1_LINEARTRANSFER_PROP.xml' path='doc/member[@name="D2D1_LINEARTRANSFER_PROP.D2D1_LINEARTRANSFER_PROP_FORCE_DWORD"]/*' />
    D2D1_LINEARTRANSFER_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
