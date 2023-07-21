﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE"]/*' />
public enum D3D12_INDIRECT_ARGUMENT_TYPE
{
    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DRAW"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_DRAW = 0,

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED = (D3D12_INDIRECT_ARGUMENT_TYPE_DRAW + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH = (D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW = (D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW = (D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT = (D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW = (D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW = (D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW = (D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS = (D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_MESH"]/*' />
    D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_MESH = (D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS + 1),
}
