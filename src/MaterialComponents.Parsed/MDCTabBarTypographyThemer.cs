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
	// @interface MDCTabBarTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCTabBarTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
		[Static]
		[Export ("applyTypographyScheme:toTabBar:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCTabBar tabBar);
	}
}
