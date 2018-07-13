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
	// @interface MDCPageControlColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCPageControlColorThemer
	{
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toPageControl:(MDCPageControl * _Nonnull)pageControl;
		[Static]
		[Export ("applyColorScheme:toPageControl:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCPageControl pageControl);
	}
}
