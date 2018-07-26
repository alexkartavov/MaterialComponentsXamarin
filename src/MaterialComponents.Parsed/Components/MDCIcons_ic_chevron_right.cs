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
	// @interface ic_chevron_right (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_ic_chevron_right
	{
		// +(NSString * _Nonnull)pathFor_ic_chevron_right;
		[Static]
		[Export ("pathFor_ic_chevron_right")]
		//[Verify (MethodToProperty)]
        string PathFor_ic_chevron_right();
		// +(UIImage * _Nullable)imageFor_ic_chevron_right;
		[Static]
		[NullAllowed, Export ("imageFor_ic_chevron_right")]
		//[Verify (MethodToProperty)]
        UIImage ImageFor_ic_chevron_right();
	}
}
