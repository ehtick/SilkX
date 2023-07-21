﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;

namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_DDDEVICEID_STRING 512")]
    public const int MAX_DDDEVICEID_STRING = 512;
}
