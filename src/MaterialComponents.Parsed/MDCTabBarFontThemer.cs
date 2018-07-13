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
	// @interface MDCTabBarFontThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCTabBarFontThemer
	{
		// +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
		[Static]
		[Export ("applyFontScheme:toTabBar:")]
		void ApplyFontScheme (MDCFontScheme fontScheme, MDCTabBar tabBar);
	}
}
