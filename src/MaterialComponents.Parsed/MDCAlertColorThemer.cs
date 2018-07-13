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
	// @interface MDCAlertColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCAlertColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAlertController:(MDCAlertController * _Nonnull)alertController;
		[Static]
		[Export ("applySemanticColorScheme:toAlertController:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCAlertController alertController);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme;
		[Static]
		[Export ("applyColorScheme:")]
		void ApplyColorScheme (MDCColorScheme colorScheme);
	}
}
