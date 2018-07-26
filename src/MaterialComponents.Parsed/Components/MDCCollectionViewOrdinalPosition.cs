using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using MaterialComponents;
using ObjCRuntime;
using UIKit;
using System.Runtime.InteropServices;

namespace MaterialComponents
{
	[Native]
	public enum MDCCollectionViewOrdinalPosition : ulong
	{
		VerticalTop = 1 << 0,
		VerticalCenter = 1 << 1,
		VerticalBottom = 1 << 2,
		VerticalTopBottom = (VerticalTop | VerticalBottom),
		HorizontalLeft = 1 << 10,
		HorizontalCenter = 1 << 11,
		HorizontalRight = 1 << 12
	}
}
