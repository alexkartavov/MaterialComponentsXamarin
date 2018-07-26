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
	public enum MDCBarButtonItemLayoutHints : ulong
	{
		None = 0,
		IsFirstButton = 1 << 0,
		IsLastButton = 1 << 1
	}
}
