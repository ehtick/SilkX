﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6"]/*' />
public unsafe partial struct ADDRINFOEX6
{
    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_flags"]/*' />
    public int ai_flags;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_family"]/*' />
    public int ai_family;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_socktype"]/*' />
    public int ai_socktype;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_protocol"]/*' />
    public int ai_protocol;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_addrlen"]/*' />
    [NativeTypeName("size_t")]
    public nuint ai_addrlen;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_canonname"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* ai_canonname;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_addr"]/*' />
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_blob"]/*' />
    public void* ai_blob;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_bloblen"]/*' />
    [NativeTypeName("size_t")]
    public nuint ai_bloblen;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_provider"]/*' />
    public Guid* ai_provider;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_next"]/*' />
    [NativeTypeName("struct addrinfoex5 *")]
    public ADDRINFOEX5* ai_next;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_version"]/*' />
    public int ai_version;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_fqdn"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* ai_fqdn;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_interfaceindex"]/*' />
    public int ai_interfaceindex;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_resolutionhandle"]/*' />
    public HANDLE ai_resolutionhandle;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_ttl"]/*' />
    [NativeTypeName("unsigned int")]
    public uint ai_ttl;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_numservers"]/*' />
    [NativeTypeName("unsigned int")]
    public uint ai_numservers;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_servers"]/*' />
    public ADDRINFO_DNS_SERVER* ai_servers;

    /// <include file='ADDRINFOEX6.xml' path='doc/member[@name="ADDRINFOEX6.ai_responseflags"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ai_responseflags;
}
