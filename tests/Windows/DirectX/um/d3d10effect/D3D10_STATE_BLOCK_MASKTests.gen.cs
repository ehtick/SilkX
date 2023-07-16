// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D10_STATE_BLOCK_MASK"/> struct.</summary>
public static unsafe partial class D3D10_STATE_BLOCK_MASKTests
{
    /// <summary>Validates that the <see cref = "D3D10_STATE_BLOCK_MASK"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D10_STATE_BLOCK_MASK>(), Is.EqualTo(sizeof(D3D10_STATE_BLOCK_MASK)));
    }

    /// <summary>Validates that the <see cref = "D3D10_STATE_BLOCK_MASK"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D10_STATE_BLOCK_MASK).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D10_STATE_BLOCK_MASK"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D10_STATE_BLOCK_MASK), Is.EqualTo(76));
    }
}