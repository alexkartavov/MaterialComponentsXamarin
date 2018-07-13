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
	public enum MDCCollectionViewCellAccessoryType : ulong
	{
		None,
		DisclosureIndicator,
		Checkmark,
		DetailButton
	}
}
