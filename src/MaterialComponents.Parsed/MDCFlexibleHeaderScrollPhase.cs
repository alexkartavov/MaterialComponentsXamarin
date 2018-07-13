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
	public enum MDCFlexibleHeaderScrollPhase : long
	{
		Shifting,
		Collapsing,
		OverExtending
	}
}
