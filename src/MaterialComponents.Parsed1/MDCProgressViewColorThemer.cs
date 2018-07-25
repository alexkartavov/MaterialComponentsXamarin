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
	// @interface MDCProgressViewColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCProgressViewColorThemer
	{
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toProgressView:(MDCProgressView * _Nonnull)progressView;
		[Static]
		[Export ("applyColorScheme:toProgressView:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCProgressView progressView);
	}
}
