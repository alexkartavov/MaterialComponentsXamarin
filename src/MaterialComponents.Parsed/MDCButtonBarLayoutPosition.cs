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
	public enum MDCButtonBarLayoutPosition : ulong
	{
		None = 0,
		Leading = 1 << 0,
		Left = Leading,
		Trailing = 1 << 1,
		Right = Trailing
	}
}
