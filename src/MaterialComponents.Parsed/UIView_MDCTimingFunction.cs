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
	// @interface MDCTimingFunction (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_MDCTimingFunction
	{
		// +(void)mdc_animateWithTimingFunction:(CAMediaTimingFunction * _Nullable)timingFunction duration:(NSTimeInterval)duration delay:(NSTimeInterval)delay options:(UIViewAnimationOptions)options animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(BOOL))completion;
		[Static]
		[Export ("mdc_animateWithTimingFunction:duration:delay:options:animations:completion:")]
		void Mdc_animateWithTimingFunction ([NullAllowed] CAMediaTimingFunction timingFunction, double duration, double delay, UIViewAnimationOptions options, Action animations, [NullAllowed] Action<bool> completion);
	}
}
