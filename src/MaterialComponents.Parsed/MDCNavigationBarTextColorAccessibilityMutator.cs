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
	// @interface MDCNavigationBarTextColorAccessibilityMutator : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCNavigationBarTextColorAccessibilityMutator
	{
		// -(void)mutate:(MDCNavigationBar * _Nonnull)navBar;
		[Export ("mutate:")]
		void Mutate (MDCNavigationBar navBar);
	}
}
