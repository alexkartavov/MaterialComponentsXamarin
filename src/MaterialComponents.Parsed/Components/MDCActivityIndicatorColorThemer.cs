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
	// @interface MDCActivityIndicatorColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCActivityIndicatorColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toActivityIndicator:(MDCActivityIndicator * _Nonnull)activityIndicator;
		[Static]
		[Export ("applySemanticColorScheme:toActivityIndicator:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCActivityIndicator activityIndicator);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toActivityIndicator:(MDCActivityIndicator * _Nonnull)activityIndicator;
		[Static]
		[Export ("applyColorScheme:toActivityIndicator:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCActivityIndicator activityIndicator);
	}
}
