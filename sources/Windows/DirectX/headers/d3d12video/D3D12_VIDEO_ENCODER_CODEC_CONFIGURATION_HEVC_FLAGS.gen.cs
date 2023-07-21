﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS"]/*' />
public enum D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_NONE"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_DISABLE_LOOP_FILTER_ACROSS_SLICES"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_DISABLE_LOOP_FILTER_ACROSS_SLICES = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_SAO_FILTER"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_SAO_FILTER = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_LONG_TERM_REFERENCES"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_LONG_TERM_REFERENCES = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_ASYMETRIC_MOTION_PARTITION"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_ASYMETRIC_MOTION_PARTITION = 0x10,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_TRANSFORM_SKIPPING"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_TRANSFORM_SKIPPING = 0x20,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_CONSTRAINED_INTRAPREDICTION"]/*' />
    D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_CONSTRAINED_INTRAPREDICTION = 0x40,
}
