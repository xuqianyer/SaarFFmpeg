﻿using System;

namespace Saar.FFmpeg.CSharp {
	[Flags]
	public enum AVChannelLayout : ulong {
		FrontLeft = 0x00000001,
		FrontRight = 0x00000002,
		FrontCenter = 0x00000004,
		LowFrequency = 0x00000008,
		BackLeft = 0x00000010,
		BackRight = 0x00000020,
		FrontLeftOfCenter = 0x00000040,
		FrontRightOfCenter = 0x00000080,
		BackCenter = 0x00000100,
		SideLeft = 0x00000200,
		SideRight = 0x00000400,
		TopCenter = 0x00000800,
		TopFrontLeft = 0x00001000,
		TopFrontCenter = 0x00002000,
		TopFrontRight = 0x00004000,
		TopBackLeft = 0x00008000,
		TopBackCenter = 0x00010000,
		TopBackRight = 0x00020000,
		StereoLeft = 0x20000000,
		StereoRight = 0x40000000,
		WideLeft = 0x0000000080000000UL,
		WideRight = 0x0000000100000000UL,
		SurroundDirectLeft = 0x0000000200000000UL,
		SurroundDirectRight = 0x0000000400000000UL,
		LowFrequency2 = 0x0000000800000000UL,
		LayoutNative = 0x8000000000000000UL,

		LayoutMono = (FrontCenter),
		LayoutStereo = (FrontLeft | FrontRight),
		Layout2point1 = (LayoutStereo | LowFrequency),
		Layout2_1 = (LayoutStereo | BackCenter),
		LayoutSurround = (LayoutStereo | FrontCenter),
		Layout3point1 = (LayoutSurround | LowFrequency),
		Layout4point0 = (LayoutSurround | BackCenter),
		Layout4point1 = (Layout4point0 | LowFrequency),
		Layout2_2 = (LayoutStereo | SideLeft | SideRight),
		LayoutQuad = (LayoutStereo | BackLeft | BackRight),
		Layout5point0 = (LayoutSurround | SideLeft | SideRight),
		Layout5point1 = (Layout5point0 | LowFrequency),
		Layout5point0Back = (LayoutSurround | BackLeft | BackRight),
		Layout5point1Back = (Layout5point0Back | LowFrequency),
		Layout6point0 = (Layout5point0 | BackCenter),
		Layout6point0Front = (Layout2_2 | FrontLeftOfCenter | FrontRightOfCenter),
		LayoutHexagonal = (Layout5point0Back | BackCenter),
		Layout6point1 = (Layout5point1 | BackCenter),
		Layout6point1Back = (Layout5point1Back | BackCenter),
		Layout6point1Front = (Layout6point0Front | LowFrequency),
		Layout7point0 = (Layout5point0 | BackLeft | BackRight),
		Layout7point0Front = (Layout5point0 | FrontLeftOfCenter | FrontRightOfCenter),
		Layout7point1 = (Layout5point1 | BackLeft | BackRight),
		Layout7point1Wide = (Layout5point1 | FrontLeftOfCenter | FrontRightOfCenter),
		Layout7point1WideBack = (Layout5point1Back | FrontLeftOfCenter | FrontRightOfCenter),
		LayoutOctagonal = (Layout5point0 | BackLeft | BackCenter | BackRight),
		LayoutHexadecagonal = (LayoutOctagonal | WideLeft | WideRight | TopBackLeft | TopBackRight | TopBackCenter | TopFrontCenter | TopFrontLeft | TopFrontRight),
		LayoutStereoDownmix = (StereoLeft | StereoRight),
	}
}
