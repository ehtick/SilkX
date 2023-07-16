// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_STREAM_STATE.xml' path='doc/member[@name="MF_STREAM_STATE"]/*'/>
public enum MF_STREAM_STATE
{
    /// <include file='MF_STREAM_STATE.xml' path='doc/member[@name="MF_STREAM_STATE.MF_STREAM_STATE_STOPPED"]/*'/>
    MF_STREAM_STATE_STOPPED = 0,
    /// <include file='MF_STREAM_STATE.xml' path='doc/member[@name="MF_STREAM_STATE.MF_STREAM_STATE_PAUSED"]/*'/>
    MF_STREAM_STATE_PAUSED = (MF_STREAM_STATE_STOPPED + 1),
    /// <include file='MF_STREAM_STATE.xml' path='doc/member[@name="MF_STREAM_STATE.MF_STREAM_STATE_RUNNING"]/*'/>
    MF_STREAM_STATE_RUNNING = (MF_STREAM_STATE_PAUSED + 1),
}