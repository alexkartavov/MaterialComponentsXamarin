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
	// @interface ic_radio_button_unchecked (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_ic_radio_button_unchecked
	{
		// +(NSString * _Nonnull)pathFor_ic_radio_button_unchecked;
		[Static]
		[Export ("pathFor_ic_radio_button_unchecked")]
		[Verify (MethodToProperty)]
		string PathFor_ic_radio_button_unchecked { get; }
		// +(UIImage * _Nullable)imageFor_ic_radio_button_unchecked;
		[Static]
		[NullAllowed, Export ("imageFor_ic_radio_button_unchecked")]
		[Verify (MethodToProperty)]
		UIImage ImageFor_ic_radio_button_unchecked { get; }
	}
}
