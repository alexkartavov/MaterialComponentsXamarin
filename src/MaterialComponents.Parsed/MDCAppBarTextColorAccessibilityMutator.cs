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
	// @interface MDCAppBarTextColorAccessibilityMutator : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCAppBarTextColorAccessibilityMutator
	{
		// -(void)mutate:(MDCAppBar * _Nonnull)appBar;
		[Export ("mutate:")]
		void Mutate (MDCAppBar appBar);
	}
}
