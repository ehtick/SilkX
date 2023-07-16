// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INIT_ONCE"/> struct.</summary>
public static unsafe partial class INIT_ONCETests
{
    /// <summary>Validates that the <see cref = "INIT_ONCE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INIT_ONCE>(), Is.EqualTo(sizeof(INIT_ONCE)));
    }

    /// <summary>Validates that the <see cref = "INIT_ONCE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(INIT_ONCE).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "INIT_ONCE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(INIT_ONCE), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(INIT_ONCE), Is.EqualTo(4));
        }
    }
}