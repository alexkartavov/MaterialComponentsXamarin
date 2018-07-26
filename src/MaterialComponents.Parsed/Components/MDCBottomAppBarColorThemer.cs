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
	// @interface MDCBottomAppBarColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCBottomAppBarColorThemer
	{
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toBottomAppBarView:(MDCBottomAppBarView * _Nonnull)bottomAppBarView;
		[Static]
		[Export ("applyColorScheme:toBottomAppBarView:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCBottomAppBarView bottomAppBarView);
	}
}
