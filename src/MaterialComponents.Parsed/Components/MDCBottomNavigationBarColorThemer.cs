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
	// @interface MDCBottomNavigationBarColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCBottomNavigationBarColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toBottomNavigation:(MDCBottomNavigationBar * _Nonnull)bottomNavigation;
		[Static]
		[Export ("applySemanticColorScheme:toBottomNavigation:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCBottomNavigationBar bottomNavigation);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toBottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar;
		[Static]
		[Export ("applyColorScheme:toBottomNavigationBar:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCBottomNavigationBar bottomNavigationBar);
	}
}
