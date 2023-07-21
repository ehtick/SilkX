﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_HIT_GROUP_DESC.xml' path='doc/member[@name="D3D12_HIT_GROUP_DESC"]/*' />
public unsafe partial struct D3D12_HIT_GROUP_DESC
{
    /// <include file='D3D12_HIT_GROUP_DESC.xml' path='doc/member[@name="D3D12_HIT_GROUP_DESC.HitGroupExport"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* HitGroupExport;

    /// <include file='D3D12_HIT_GROUP_DESC.xml' path='doc/member[@name="D3D12_HIT_GROUP_DESC.Type"]/*' />
    public D3D12_HIT_GROUP_TYPE Type;

    /// <include file='D3D12_HIT_GROUP_DESC.xml' path='doc/member[@name="D3D12_HIT_GROUP_DESC.AnyHitShaderImport"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* AnyHitShaderImport;

    /// <include file='D3D12_HIT_GROUP_DESC.xml' path='doc/member[@name="D3D12_HIT_GROUP_DESC.ClosestHitShaderImport"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* ClosestHitShaderImport;

    /// <include file='D3D12_HIT_GROUP_DESC.xml' path='doc/member[@name="D3D12_HIT_GROUP_DESC.IntersectionShaderImport"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* IntersectionShaderImport;
}
