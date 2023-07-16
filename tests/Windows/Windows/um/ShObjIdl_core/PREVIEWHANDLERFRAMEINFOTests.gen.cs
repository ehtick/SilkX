// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PREVIEWHANDLERFRAMEINFO"/> struct.</summary>
public static unsafe partial class PREVIEWHANDLERFRAMEINFOTests
{
    /// <summary>Validates that the <see cref = "PREVIEWHANDLERFRAMEINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PREVIEWHANDLERFRAMEINFO>(), Is.EqualTo(sizeof(PREVIEWHANDLERFRAMEINFO)));
    }

    /// <summary>Validates that the <see cref = "PREVIEWHANDLERFRAMEINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PREVIEWHANDLERFRAMEINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PREVIEWHANDLERFRAMEINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PREVIEWHANDLERFRAMEINFO), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(PREVIEWHANDLERFRAMEINFO), Is.EqualTo(8));
        }
    }
}