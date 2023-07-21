﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID"]/*' />
public enum DWRITE_FONT_PROPERTY_ID
{
    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_NONE"]/*' />
    DWRITE_FONT_PROPERTY_ID_NONE,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FAMILY_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FAMILY_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FAMILY_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FAMILY_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FACE_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FACE_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_FULL_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_FULL_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_WIN32_FAMILY_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_WIN32_FAMILY_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_POSTSCRIPT_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_POSTSCRIPT_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG"]/*' />
    DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_SUPPORTED_SCRIPT_LANGUAGE_TAG"]/*' />
    DWRITE_FONT_PROPERTY_ID_SUPPORTED_SCRIPT_LANGUAGE_TAG,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_SEMANTIC_TAG"]/*' />
    DWRITE_FONT_PROPERTY_ID_SEMANTIC_TAG,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_WEIGHT"]/*' />
    DWRITE_FONT_PROPERTY_ID_WEIGHT,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_STRETCH"]/*' />
    DWRITE_FONT_PROPERTY_ID_STRETCH,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_STYLE"]/*' />
    DWRITE_FONT_PROPERTY_ID_STYLE,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FACE_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FACE_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_TOTAL"]/*' />
    DWRITE_FONT_PROPERTY_ID_TOTAL = DWRITE_FONT_PROPERTY_ID_STYLE + 1,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_TOTAL_RS3"]/*' />
    DWRITE_FONT_PROPERTY_ID_TOTAL_RS3 = DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FACE_NAME + 1,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_PREFERRED_FAMILY_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_PREFERRED_FAMILY_NAME = DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FAMILY_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_FAMILY_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_FAMILY_NAME = DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FAMILY_NAME,

    /// <include file='DWRITE_FONT_PROPERTY_ID.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_FACE_NAME"]/*' />
    DWRITE_FONT_PROPERTY_ID_FACE_NAME = DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FACE_NAME,
}
