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
	// @interface MDCInkColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCInkColorThemer
	{
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toInkView:(MDCInkView * _Nonnull)inkView;
		[Static]
		[Export ("applyColorScheme:toInkView:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCInkView inkView);
	}
}
