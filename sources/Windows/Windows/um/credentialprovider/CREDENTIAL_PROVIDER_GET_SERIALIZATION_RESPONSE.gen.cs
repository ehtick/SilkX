﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE"]/*' />
public enum CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE
{
    /// <include file='CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.CPGSR_NO_CREDENTIAL_NOT_FINISHED"]/*' />
    CPGSR_NO_CREDENTIAL_NOT_FINISHED = 0,

    /// <include file='CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.CPGSR_NO_CREDENTIAL_FINISHED"]/*' />
    CPGSR_NO_CREDENTIAL_FINISHED = (CPGSR_NO_CREDENTIAL_NOT_FINISHED + 1),

    /// <include file='CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.CPGSR_RETURN_CREDENTIAL_FINISHED"]/*' />
    CPGSR_RETURN_CREDENTIAL_FINISHED = (CPGSR_NO_CREDENTIAL_FINISHED + 1),

    /// <include file='CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE.CPGSR_RETURN_NO_CREDENTIAL_FINISHED"]/*' />
    CPGSR_RETURN_NO_CREDENTIAL_FINISHED = (CPGSR_RETURN_CREDENTIAL_FINISHED + 1),
}
