// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CPrintManagerTemplatePrinter.xml' path='doc/member[@name="CPrintManagerTemplatePrinter"]/*'/>
[Guid("63619F54-9D71-4C23-A08D-50D7F18DB2E9")]
public unsafe partial struct CPrintManagerTemplatePrinter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CPrintManagerTemplatePrinter));
}