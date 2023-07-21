﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID"]/*' />
public enum WS_SECURITY_ALGORITHM_ID
{
    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_DEFAULT"]/*' />
    WS_SECURITY_ALGORITHM_DEFAULT = 0,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_CANONICALIZATION_EXCLUSIVE"]/*' />
    WS_SECURITY_ALGORITHM_CANONICALIZATION_EXCLUSIVE = 1,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_CANONICALIZATION_EXCLUSIVE_WITH_COMMENTS"]/*' />
    WS_SECURITY_ALGORITHM_CANONICALIZATION_EXCLUSIVE_WITH_COMMENTS = 2,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_DIGEST_SHA1"]/*' />
    WS_SECURITY_ALGORITHM_DIGEST_SHA1 = 3,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_DIGEST_SHA_256"]/*' />
    WS_SECURITY_ALGORITHM_DIGEST_SHA_256 = 4,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_DIGEST_SHA_384"]/*' />
    WS_SECURITY_ALGORITHM_DIGEST_SHA_384 = 5,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_DIGEST_SHA_512"]/*' />
    WS_SECURITY_ALGORITHM_DIGEST_SHA_512 = 6,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_SYMMETRIC_SIGNATURE_HMAC_SHA1"]/*' />
    WS_SECURITY_ALGORITHM_SYMMETRIC_SIGNATURE_HMAC_SHA1 = 7,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_SYMMETRIC_SIGNATURE_HMAC_SHA_256"]/*' />
    WS_SECURITY_ALGORITHM_SYMMETRIC_SIGNATURE_HMAC_SHA_256 = 8,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_SYMMETRIC_SIGNATURE_HMAC_SHA_384"]/*' />
    WS_SECURITY_ALGORITHM_SYMMETRIC_SIGNATURE_HMAC_SHA_384 = 9,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_SYMMETRIC_SIGNATURE_HMAC_SHA_512"]/*' />
    WS_SECURITY_ALGORITHM_SYMMETRIC_SIGNATURE_HMAC_SHA_512 = 10,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_RSA_SHA1"]/*' />
    WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_RSA_SHA1 = 11,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_DSA_SHA1"]/*' />
    WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_DSA_SHA1 = 12,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_RSA_SHA_256"]/*' />
    WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_RSA_SHA_256 = 13,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_RSA_SHA_384"]/*' />
    WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_RSA_SHA_384 = 14,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_RSA_SHA_512"]/*' />
    WS_SECURITY_ALGORITHM_ASYMMETRIC_SIGNATURE_RSA_SHA_512 = 15,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_ASYMMETRIC_KEYWRAP_RSA_1_5"]/*' />
    WS_SECURITY_ALGORITHM_ASYMMETRIC_KEYWRAP_RSA_1_5 = 16,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_ASYMMETRIC_KEYWRAP_RSA_OAEP"]/*' />
    WS_SECURITY_ALGORITHM_ASYMMETRIC_KEYWRAP_RSA_OAEP = 17,

    /// <include file='WS_SECURITY_ALGORITHM_ID.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_ID.WS_SECURITY_ALGORITHM_KEY_DERIVATION_P_SHA1"]/*' />
    WS_SECURITY_ALGORITHM_KEY_DERIVATION_P_SHA1 = 18,
}
