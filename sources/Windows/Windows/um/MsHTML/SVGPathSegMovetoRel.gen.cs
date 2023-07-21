﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='SVGPathSegMovetoRel.xml' path='doc/member[@name="SVGPathSegMovetoRel"]/*' />
[Guid("305105CD-98B5-11CF-BB82-00AA00BDCE0B")]
public unsafe partial struct SVGPathSegMovetoRel : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_SVGPathSegMovetoRel));
}
