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
	// @interface MDCButtonBarColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCButtonBarColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar;
		[Static]
		[Export ("applySemanticColorScheme:toButtonBar:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCButtonBar buttonBar);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar;
		[Static]
		[Export ("applyColorScheme:toButtonBar:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCButtonBar buttonBar);
	}
}
