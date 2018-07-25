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
	// @interface MDCButtonTitleColorAccessibilityMutator : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCButtonTitleColorAccessibilityMutator
	{
		// +(void)changeTitleColorOfButton:(MDCButton *)button;
		[Static]
		[Export ("changeTitleColorOfButton:")]
		void ChangeTitleColorOfButton (MDCButton button);
	}
}
