// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CTL_USAGE_MATCH"/> struct.</summary>
public static unsafe partial class CTL_USAGE_MATCHTests
{
    /// <summary>Validates that the <see cref = "CTL_USAGE_MATCH"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CTL_USAGE_MATCH>(), Is.EqualTo(sizeof(CTL_USAGE_MATCH)));
    }

    /// <summary>Validates that the <see cref = "CTL_USAGE_MATCH"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CTL_USAGE_MATCH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CTL_USAGE_MATCH"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CTL_USAGE_MATCH), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CTL_USAGE_MATCH), Is.EqualTo(12));
        }
    }
}