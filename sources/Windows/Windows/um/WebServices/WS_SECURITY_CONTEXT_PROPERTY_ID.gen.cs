﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SECURITY_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_PROPERTY_ID"]/*' />
public enum WS_SECURITY_CONTEXT_PROPERTY_ID
{
    /// <include file='WS_SECURITY_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_PROPERTY_ID.WS_SECURITY_CONTEXT_PROPERTY_IDENTIFIER"]/*' />
    WS_SECURITY_CONTEXT_PROPERTY_IDENTIFIER = 1,

    /// <include file='WS_SECURITY_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_PROPERTY_ID.WS_SECURITY_CONTEXT_PROPERTY_USERNAME"]/*' />
    WS_SECURITY_CONTEXT_PROPERTY_USERNAME = 2,

    /// <include file='WS_SECURITY_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_PROPERTY_ID.WS_SECURITY_CONTEXT_PROPERTY_MESSAGE_SECURITY_WINDOWS_TOKEN"]/*' />
    WS_SECURITY_CONTEXT_PROPERTY_MESSAGE_SECURITY_WINDOWS_TOKEN = 3,

    /// <include file='WS_SECURITY_CONTEXT_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_CONTEXT_PROPERTY_ID.WS_SECURITY_CONTEXT_PROPERTY_SAML_ASSERTION"]/*' />
    WS_SECURITY_CONTEXT_PROPERTY_SAML_ASSERTION = 4,
}
