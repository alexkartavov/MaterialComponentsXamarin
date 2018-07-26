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
	// @interface ic_more_horiz (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_ic_more_horiz
	{
		// +(NSString * _Nonnull)pathFor_ic_more_horiz;
		[Static]
		[Export ("pathFor_ic_more_horiz")]
		//[Verify (MethodToProperty)]
        string PathFor_ic_more_horiz();
		// +(UIImage * _Nullable)imageFor_ic_more_horiz;
		[Static]
		[NullAllowed, Export ("imageFor_ic_more_horiz")]
		//[Verify (MethodToProperty)]
        UIImage ImageFor_ic_more_horiz();
	}
}
