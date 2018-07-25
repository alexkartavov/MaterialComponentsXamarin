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
	public enum MDCTextInputTextInsetsMode : ulong
	{
		Never = 0,
		IfContent,
		Always
	}
}
