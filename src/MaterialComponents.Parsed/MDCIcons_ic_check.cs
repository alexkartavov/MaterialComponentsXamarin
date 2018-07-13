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
	// @interface ic_check (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_ic_check
	{
		// +(NSString * _Nonnull)pathFor_ic_check;
		[Static]
		[Export ("pathFor_ic_check")]
		[Verify (MethodToProperty)]
		string PathFor_ic_check { get; }
		// +(UIImage * _Nullable)imageFor_ic_check;
		[Static]
		[NullAllowed, Export ("imageFor_ic_check")]
		[Verify (MethodToProperty)]
		UIImage ImageFor_ic_check { get; }
	}
}
