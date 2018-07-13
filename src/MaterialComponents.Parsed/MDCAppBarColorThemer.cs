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
	// @interface MDCAppBarColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCAppBarColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
		[Static]
		[Export ("applySemanticColorScheme:toAppBar:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCAppBar appBar);
		// +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
		[Static]
		[Export ("applySurfaceVariantWithColorScheme:toAppBar:")]
		void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCAppBar appBar);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
		[Static]
		[Export ("applyColorScheme:toAppBar:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCAppBar appBar);
	}
}
