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
	// @interface ic_settings (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_ic_settings
	{
		// +(NSString * _Nonnull)pathFor_ic_settings;
		[Static]
		[Export ("pathFor_ic_settings")]
		[Verify (MethodToProperty)]
		string PathFor_ic_settings { get; }
		// +(UIImage * _Nullable)imageFor_ic_settings;
		[Static]
		[NullAllowed, Export ("imageFor_ic_settings")]
		[Verify (MethodToProperty)]
		UIImage ImageFor_ic_settings { get; }
	}
}
