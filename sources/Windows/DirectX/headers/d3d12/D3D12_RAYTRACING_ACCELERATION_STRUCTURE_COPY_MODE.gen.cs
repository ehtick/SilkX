﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE"]/*' />
public enum D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE
{
    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_CLONE"]/*' />
    D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_CLONE = 0,

    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_COMPACT"]/*' />
    D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_COMPACT = 0x1,

    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_VISUALIZATION_DECODE_FOR_TOOLS"]/*' />
    D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_VISUALIZATION_DECODE_FOR_TOOLS = 0x2,

    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_SERIALIZE"]/*' />
    D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_SERIALIZE = 0x3,

    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_DESERIALIZE"]/*' />
    D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_DESERIALIZE = 0x4,
}
