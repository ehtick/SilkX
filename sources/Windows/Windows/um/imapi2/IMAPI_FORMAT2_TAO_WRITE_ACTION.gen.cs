// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAPI_FORMAT2_TAO_WRITE_ACTION.xml' path='doc/member[@name="IMAPI_FORMAT2_TAO_WRITE_ACTION"]/*'/>
public enum IMAPI_FORMAT2_TAO_WRITE_ACTION
{
    /// <include file='IMAPI_FORMAT2_TAO_WRITE_ACTION.xml' path='doc/member[@name="IMAPI_FORMAT2_TAO_WRITE_ACTION.IMAPI_FORMAT2_TAO_WRITE_ACTION_UNKNOWN"]/*'/>
    IMAPI_FORMAT2_TAO_WRITE_ACTION_UNKNOWN = 0,
    /// <include file='IMAPI_FORMAT2_TAO_WRITE_ACTION.xml' path='doc/member[@name="IMAPI_FORMAT2_TAO_WRITE_ACTION.IMAPI_FORMAT2_TAO_WRITE_ACTION_PREPARING"]/*'/>
    IMAPI_FORMAT2_TAO_WRITE_ACTION_PREPARING = 0x1,
    /// <include file='IMAPI_FORMAT2_TAO_WRITE_ACTION.xml' path='doc/member[@name="IMAPI_FORMAT2_TAO_WRITE_ACTION.IMAPI_FORMAT2_TAO_WRITE_ACTION_WRITING"]/*'/>
    IMAPI_FORMAT2_TAO_WRITE_ACTION_WRITING = 0x2,
    /// <include file='IMAPI_FORMAT2_TAO_WRITE_ACTION.xml' path='doc/member[@name="IMAPI_FORMAT2_TAO_WRITE_ACTION.IMAPI_FORMAT2_TAO_WRITE_ACTION_FINISHING"]/*'/>
    IMAPI_FORMAT2_TAO_WRITE_ACTION_FINISHING = 0x3,
    /// <include file='IMAPI_FORMAT2_TAO_WRITE_ACTION.xml' path='doc/member[@name="IMAPI_FORMAT2_TAO_WRITE_ACTION.IMAPI_FORMAT2_TAO_WRITE_ACTION_VERIFYING"]/*'/>
    IMAPI_FORMAT2_TAO_WRITE_ACTION_VERIFYING = 0x4,
}