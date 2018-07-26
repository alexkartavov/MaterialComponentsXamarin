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
	public enum MDCChipFieldDelimiter : ulong
	{
		None = 0,
		Return = 1 << 0,
		Space = 1 << 1,
		DidEndEditing = 1 << 2,
		Default = (Return | DidEndEditing),
		All = 4294967295L
	}
}
