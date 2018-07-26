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
	// @interface MDCFeatureHighlightAccessibilityMutator : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCFeatureHighlightAccessibilityMutator
	{
		// +(void)mutate:(MDCFeatureHighlightViewController *)featureHighlightViewController;
		[Static]
		[Export ("mutate:")]
		void Mutate (MDCFeatureHighlightViewController featureHighlightViewController);
	}
}
