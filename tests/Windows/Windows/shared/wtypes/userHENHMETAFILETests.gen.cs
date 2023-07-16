// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "userHENHMETAFILE"/> struct.</summary>
public static unsafe partial class userHENHMETAFILETests
{
    /// <summary>Validates that the <see cref = "userHENHMETAFILE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<userHENHMETAFILE>(), Is.EqualTo(sizeof(userHENHMETAFILE)));
    }

    /// <summary>Validates that the <see cref = "userHENHMETAFILE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(userHENHMETAFILE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "userHENHMETAFILE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(userHENHMETAFILE), Is.EqualTo(16));
    }
}