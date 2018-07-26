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
	// @interface ic_help_outline (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_ic_help_outline
	{
		// +(NSString * _Nonnull)pathFor_ic_help_outline;
		[Static]
		[Export ("pathFor_ic_help_outline")]
		//[Verify (MethodToProperty)]
        string PathFor_ic_help_outline();
		// +(UIImage * _Nullable)imageFor_ic_help_outline;
		[Static]
		[NullAllowed, Export ("imageFor_ic_help_outline")]
		//[Verify (MethodToProperty)]
        UIImage ImageFor_ic_help_outline();
	}
}
