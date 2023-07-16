// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE"]/*'/>
public enum DWRITE_PANOSE_ARM_STYLE
{
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_ANY"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_ANY = 0,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_NO_FIT"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_NO_FIT = 1,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORIZONTAL"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORIZONTAL = 2,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_WEDGE"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_WEDGE = 3,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERTICAL"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERTICAL = 4,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_SINGLE_SERIF"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_SINGLE_SERIF = 5,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_DOUBLE_SERIF"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_DOUBLE_SERIF = 6,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_HORIZONTAL"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_HORIZONTAL = 7,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_WEDGE"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_WEDGE = 8,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_VERTICAL"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_VERTICAL = 9,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_SINGLE_SERIF"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_SINGLE_SERIF = 10,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_DOUBLE_SERIF"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_DOUBLE_SERIF = 11,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORZ"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORZ = DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORIZONTAL,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERT"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERT = DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERTICAL,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_HORZ"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_HORZ = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_HORIZONTAL,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_WEDGE"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_WEDGE = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_WEDGE,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_VERT"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_VERT = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_VERTICAL,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_SINGLE_SERIF"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_SINGLE_SERIF = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_SINGLE_SERIF,
    /// <include file='DWRITE_PANOSE_ARM_STYLE.xml' path='doc/member[@name="DWRITE_PANOSE_ARM_STYLE.DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_DOUBLE_SERIF"]/*'/>
    DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_DOUBLE_SERIF = DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_DOUBLE_SERIF,
}