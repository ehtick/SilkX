﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable"]/*' />
[NativeTypeName("struct ID3D10EffectMatrixVariable : ID3D10EffectVariable")]
[NativeInheritance("ID3D10EffectVariable")]
public unsafe partial struct ID3D10EffectMatrixVariable : ID3D10EffectMatrixVariable.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="ID3D10EffectVariable.IsValid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsValid()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, int>)(lpVtbl[0]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public new ID3D10EffectType* GetType()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectType*>)(lpVtbl[1]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetDesc(D3D10_EFFECT_VARIABLE_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, D3D10_EFFECT_VARIABLE_DESC*, int>)(lpVtbl[2]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetAnnotationByIndex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public ID3D10EffectVariable* GetAnnotationByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, uint, ID3D10EffectVariable*>)(lpVtbl[3]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), Index);
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetAnnotationByName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[4]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetMemberByIndex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D10EffectVariable* GetMemberByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, uint, ID3D10EffectVariable*>)(lpVtbl[5]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), Index);
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetMemberByName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public ID3D10EffectVariable* GetMemberByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[6]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetMemberBySemantic" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public ID3D10EffectVariable* GetMemberBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[7]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), Semantic);
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetElement" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public ID3D10EffectVariable* GetElement(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, uint, ID3D10EffectVariable*>)(lpVtbl[8]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), Index);
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetParentConstantBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public ID3D10EffectConstantBuffer* GetParentConstantBuffer()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectConstantBuffer*>)(lpVtbl[9]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsScalar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public ID3D10EffectScalarVariable* AsScalar()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectScalarVariable*>)(lpVtbl[10]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsVector" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public ID3D10EffectVectorVariable* AsVector()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectVectorVariable*>)(lpVtbl[11]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsMatrix" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public ID3D10EffectMatrixVariable* AsMatrix()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectMatrixVariable*>)(lpVtbl[12]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public ID3D10EffectStringVariable* AsString()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectStringVariable*>)(lpVtbl[13]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsShaderResource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public ID3D10EffectShaderResourceVariable* AsShaderResource()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectShaderResourceVariable*>)(lpVtbl[14]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsRenderTargetView" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public ID3D10EffectRenderTargetViewVariable* AsRenderTargetView()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectRenderTargetViewVariable*>)(lpVtbl[15]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsDepthStencilView" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public ID3D10EffectDepthStencilViewVariable* AsDepthStencilView()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectDepthStencilViewVariable*>)(lpVtbl[16]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsConstantBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public ID3D10EffectConstantBuffer* AsConstantBuffer()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectConstantBuffer*>)(lpVtbl[17]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsShader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public ID3D10EffectShaderVariable* AsShader()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectShaderVariable*>)(lpVtbl[18]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsBlend" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public ID3D10EffectBlendVariable* AsBlend()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectBlendVariable*>)(lpVtbl[19]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsDepthStencil" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public ID3D10EffectDepthStencilVariable* AsDepthStencil()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectDepthStencilVariable*>)(lpVtbl[20]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsRasterizer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public ID3D10EffectRasterizerVariable* AsRasterizer()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectRasterizerVariable*>)(lpVtbl[21]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.AsSampler" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public ID3D10EffectSamplerVariable* AsSampler()
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, ID3D10EffectSamplerVariable*>)(lpVtbl[22]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D10EffectVariable.SetRawValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetRawValue(void* pData, uint Offset, uint ByteCount)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, void*, uint, uint, int>)(lpVtbl[23]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData, Offset, ByteCount);
    }

    /// <inheritdoc cref="ID3D10EffectVariable.GetRawValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetRawValue(void* pData, uint Offset, uint ByteCount)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, void*, uint, uint, int>)(lpVtbl[24]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData, Offset, ByteCount);
    }

    /// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable.SetMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetMatrix(float* pData)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, float*, int>)(lpVtbl[25]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData);
    }

    /// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable.GetMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetMatrix(float* pData)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, float*, int>)(lpVtbl[26]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData);
    }

    /// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable.SetMatrixArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetMatrixArray(float* pData, uint Offset, uint Count)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, float*, uint, uint, int>)(lpVtbl[27]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData, Offset, Count);
    }

    /// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable.GetMatrixArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetMatrixArray(float* pData, uint Offset, uint Count)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, float*, uint, uint, int>)(lpVtbl[28]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData, Offset, Count);
    }

    /// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable.SetMatrixTranspose"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetMatrixTranspose(float* pData)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, float*, int>)(lpVtbl[29]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData);
    }

    /// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable.GetMatrixTranspose"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetMatrixTranspose(float* pData)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, float*, int>)(lpVtbl[30]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData);
    }

    /// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable.SetMatrixTransposeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetMatrixTransposeArray(float* pData, uint Offset, uint Count)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, float*, uint, uint, int>)(lpVtbl[31]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData, Offset, Count);
    }

    /// <include file='ID3D10EffectMatrixVariable.xml' path='doc/member[@name="ID3D10EffectMatrixVariable.GetMatrixTransposeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetMatrixTransposeArray(float* pData, uint Offset, uint Count)
    {
        return ((delegate* unmanaged<ID3D10EffectMatrixVariable*, float*, uint, uint, int>)(lpVtbl[32]))((ID3D10EffectMatrixVariable*)Unsafe.AsPointer(ref this), pData, Offset, Count);
    }

    public interface Interface : ID3D10EffectVariable.Interface
    {
        [VtblIndex(25)]
        HRESULT SetMatrix(float* pData);

        [VtblIndex(26)]
        HRESULT GetMatrix(float* pData);

        [VtblIndex(27)]
        HRESULT SetMatrixArray(float* pData, uint Offset, uint Count);

        [VtblIndex(28)]
        HRESULT GetMatrixArray(float* pData, uint Offset, uint Count);

        [VtblIndex(29)]
        HRESULT SetMatrixTranspose(float* pData);

        [VtblIndex(30)]
        HRESULT GetMatrixTranspose(float* pData);

        [VtblIndex(31)]
        HRESULT SetMatrixTransposeArray(float* pData, uint Offset, uint Count);

        [VtblIndex(32)]
        HRESULT GetMatrixTransposeArray(float* pData, uint Offset, uint Count);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsValid;

        [NativeTypeName("ID3D10EffectType *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, ID3D10EffectType*> GetType;

        [NativeTypeName("HRESULT (D3D10_EFFECT_VARIABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_EFFECT_VARIABLE_DESC*, int> GetDesc;

        [NativeTypeName("ID3D10EffectVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectVariable*> GetAnnotationByIndex;

        [NativeTypeName("ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetAnnotationByName;

        [NativeTypeName("ID3D10EffectVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectVariable*> GetMemberByIndex;

        [NativeTypeName("ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetMemberByName;

        [NativeTypeName("ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetMemberBySemantic;

        [NativeTypeName("ID3D10EffectVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectVariable*> GetElement;

        [NativeTypeName("ID3D10EffectConstantBuffer *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectConstantBuffer*> GetParentConstantBuffer;

        [NativeTypeName("ID3D10EffectScalarVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectScalarVariable*> AsScalar;

        [NativeTypeName("ID3D10EffectVectorVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectVectorVariable*> AsVector;

        [NativeTypeName("ID3D10EffectMatrixVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectMatrixVariable*> AsMatrix;

        [NativeTypeName("ID3D10EffectStringVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectStringVariable*> AsString;

        [NativeTypeName("ID3D10EffectShaderResourceVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectShaderResourceVariable*> AsShaderResource;

        [NativeTypeName("ID3D10EffectRenderTargetViewVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectRenderTargetViewVariable*> AsRenderTargetView;

        [NativeTypeName("ID3D10EffectDepthStencilViewVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectDepthStencilViewVariable*> AsDepthStencilView;

        [NativeTypeName("ID3D10EffectConstantBuffer *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectConstantBuffer*> AsConstantBuffer;

        [NativeTypeName("ID3D10EffectShaderVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectShaderVariable*> AsShader;

        [NativeTypeName("ID3D10EffectBlendVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectBlendVariable*> AsBlend;

        [NativeTypeName("ID3D10EffectDepthStencilVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectDepthStencilVariable*> AsDepthStencil;

        [NativeTypeName("ID3D10EffectRasterizerVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectRasterizerVariable*> AsRasterizer;

        [NativeTypeName("ID3D10EffectSamplerVariable *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10EffectSamplerVariable*> AsSampler;

        [NativeTypeName("HRESULT (void *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint, int> SetRawValue;

        [NativeTypeName("HRESULT (void *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint, int> GetRawValue;

        [NativeTypeName("HRESULT (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> SetMatrix;

        [NativeTypeName("HRESULT (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetMatrix;

        [NativeTypeName("HRESULT (float *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, uint, int> SetMatrixArray;

        [NativeTypeName("HRESULT (float *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, uint, int> GetMatrixArray;

        [NativeTypeName("HRESULT (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> SetMatrixTranspose;

        [NativeTypeName("HRESULT (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetMatrixTranspose;

        [NativeTypeName("HRESULT (float *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, uint, int> SetMatrixTransposeArray;

        [NativeTypeName("HRESULT (float *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, uint, int> GetMatrixTransposeArray;
    }
}
