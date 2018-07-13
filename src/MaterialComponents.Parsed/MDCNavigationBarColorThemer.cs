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
	// @interface MDCNavigationBarColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCNavigationBarColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
		[Static]
		[Export ("applySemanticColorScheme:toNavigationBar:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCNavigationBar navigationBar);
		// +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
		[Static]
		[Export ("applySurfaceVariantWithColorScheme:toNavigationBar:")]
		void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCNavigationBar navigationBar);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
		[Static]
		[Export ("applyColorScheme:toNavigationBar:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCNavigationBar navigationBar);
	}
}
