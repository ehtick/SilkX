// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY"]/*'/>
public enum D3D12_MESSAGE_CATEGORY
{
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED"]/*'/>
    D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED = 0,
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_MISCELLANEOUS"]/*'/>
    D3D12_MESSAGE_CATEGORY_MISCELLANEOUS = (D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_INITIALIZATION"]/*'/>
    D3D12_MESSAGE_CATEGORY_INITIALIZATION = (D3D12_MESSAGE_CATEGORY_MISCELLANEOUS + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_CLEANUP"]/*'/>
    D3D12_MESSAGE_CATEGORY_CLEANUP = (D3D12_MESSAGE_CATEGORY_INITIALIZATION + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_COMPILATION"]/*'/>
    D3D12_MESSAGE_CATEGORY_COMPILATION = (D3D12_MESSAGE_CATEGORY_CLEANUP + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_STATE_CREATION"]/*'/>
    D3D12_MESSAGE_CATEGORY_STATE_CREATION = (D3D12_MESSAGE_CATEGORY_COMPILATION + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_STATE_SETTING"]/*'/>
    D3D12_MESSAGE_CATEGORY_STATE_SETTING = (D3D12_MESSAGE_CATEGORY_STATE_CREATION + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_STATE_GETTING"]/*'/>
    D3D12_MESSAGE_CATEGORY_STATE_GETTING = (D3D12_MESSAGE_CATEGORY_STATE_SETTING + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION"]/*'/>
    D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION = (D3D12_MESSAGE_CATEGORY_STATE_GETTING + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_EXECUTION"]/*'/>
    D3D12_MESSAGE_CATEGORY_EXECUTION = (D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION + 1),
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_SHADER"]/*'/>
    D3D12_MESSAGE_CATEGORY_SHADER = (D3D12_MESSAGE_CATEGORY_EXECUTION + 1),
}