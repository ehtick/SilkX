﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='WS_XML_WRITER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_BINARY_ENCODING"]/*' />
public unsafe partial struct WS_XML_WRITER_BINARY_ENCODING
{
    /// <include file='WS_XML_WRITER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_BINARY_ENCODING.encoding"]/*' />
    public WS_XML_WRITER_ENCODING encoding;

    /// <include file='WS_XML_WRITER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_BINARY_ENCODING.staticDictionary"]/*' />
    public WS_XML_DICTIONARY* staticDictionary;

    /// <include file='WS_XML_WRITER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_BINARY_ENCODING.dynamicStringCallback"]/*' />
    [NativeTypeName("WS_DYNAMIC_STRING_CALLBACK")]
    public delegate* unmanaged<void*, WS_XML_STRING*, BOOL*, uint*, IntPtr, HRESULT> dynamicStringCallback;

    /// <include file='WS_XML_WRITER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_BINARY_ENCODING.dynamicStringCallbackState"]/*' />
    public void* dynamicStringCallbackState;
}
