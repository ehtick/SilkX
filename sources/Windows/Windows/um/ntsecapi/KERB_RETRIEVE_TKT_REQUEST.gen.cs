// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_RETRIEVE_TKT_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_REQUEST"]/*'/>
public partial struct KERB_RETRIEVE_TKT_REQUEST
{
    /// <include file='KERB_RETRIEVE_TKT_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_REQUEST.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_RETRIEVE_TKT_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_REQUEST.LogonId"]/*'/>
    public LUID LogonId;
    /// <include file='KERB_RETRIEVE_TKT_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_REQUEST.TargetName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING TargetName;
    /// <include file='KERB_RETRIEVE_TKT_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_REQUEST.TicketFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TicketFlags;
    /// <include file='KERB_RETRIEVE_TKT_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_REQUEST.CacheOptions"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CacheOptions;
    /// <include file='KERB_RETRIEVE_TKT_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_REQUEST.EncryptionType"]/*'/>
    [NativeTypeName("LONG")]
    public int EncryptionType;
    /// <include file='KERB_RETRIEVE_TKT_REQUEST.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_REQUEST.CredentialsHandle"]/*'/>
    public SecHandle CredentialsHandle;
}