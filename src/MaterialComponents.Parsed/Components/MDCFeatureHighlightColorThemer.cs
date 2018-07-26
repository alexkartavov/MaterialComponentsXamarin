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
	// @interface MDCFeatureHighlightColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCFeatureHighlightColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFeatureHighlightViewController:(MDCFeatureHighlightViewController * _Nonnull)featureHighlightViewController;
		[Static]
		[Export ("applySemanticColorScheme:toFeatureHighlightViewController:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCFeatureHighlightViewController featureHighlightViewController);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toFeatureHighlightView:(MDCFeatureHighlightView * _Nonnull)featureHighlightView;
		[Static]
		[Export ("applyColorScheme:toFeatureHighlightView:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCFeatureHighlightView featureHighlightView);
	}
}
