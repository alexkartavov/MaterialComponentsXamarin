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
	// @interface MDCAnimationTiming (CAMediaTimingFunction)
	[Category]
	[BaseType (typeof(CAMediaTimingFunction))]
	interface CAMediaTimingFunction_MDCAnimationTiming
	{
		// +(CAMediaTimingFunction * _Nullable)mdc_functionWithType:(MDCAnimationTimingFunction)type;
		[Static]
		[Export ("mdc_functionWithType:")]
		[return: NullAllowed]
		CAMediaTimingFunction Mdc_functionWithType (MDCAnimationTimingFunction type);
	}
}
