﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMHEADERW.xml' path='doc/member[@name="NMHEADERW"]/*' />
public unsafe partial struct NMHEADERW
{
    /// <include file='NMHEADERW.xml' path='doc/member[@name="NMHEADERW.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMHEADERW.xml' path='doc/member[@name="NMHEADERW.iItem"]/*' />
    public int iItem;

    /// <include file='NMHEADERW.xml' path='doc/member[@name="NMHEADERW.iButton"]/*' />
    public int iButton;

    /// <include file='NMHEADERW.xml' path='doc/member[@name="NMHEADERW.pitem"]/*' />
    public HDITEMW* pitem;
}
