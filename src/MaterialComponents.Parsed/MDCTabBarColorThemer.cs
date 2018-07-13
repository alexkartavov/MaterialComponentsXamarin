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
	// @interface MDCTabBarColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCTabBarColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTabs:(MDCTabBar * _Nonnull)tabBar;
		[Static]
		[Export ("applySemanticColorScheme:toTabs:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTabBar tabBar);
		// +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTabs:(MDCTabBar * _Nonnull)tabBar;
		[Static]
		[Export ("applySurfaceVariantWithColorScheme:toTabs:")]
		void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCTabBar tabBar);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
		[Static]
		[Export ("applyColorScheme:toTabBar:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCTabBar tabBar);
	}
}
