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
	public enum MDCCardCellState : long
	{
		Normal = 0,
		Highlighted,
		Selected
	}
}
