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
	// @interface ic_reorder (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_ic_reorder
	{
		// +(NSString * _Nonnull)pathFor_ic_reorder;
		[Static]
		[Export ("pathFor_ic_reorder")]
		//[Verify (MethodToProperty)]
        string PathFor_ic_reorder();
		// +(UIImage * _Nullable)imageFor_ic_reorder;
		[Static]
		[NullAllowed, Export ("imageFor_ic_reorder")]
		//[Verify (MethodToProperty)]
        UIImage ImageFor_ic_reorder();
	}
}
