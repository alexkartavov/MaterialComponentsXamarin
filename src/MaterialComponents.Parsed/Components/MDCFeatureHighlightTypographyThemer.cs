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
	// @interface MDCFeatureHighlightTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCFeatureHighlightTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toFeatureHighlightViewController:(MDCFeatureHighlightViewController * _Nonnull)featureHighlightViewController;
		[Static]
		[Export ("applyTypographyScheme:toFeatureHighlightViewController:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCFeatureHighlightViewController featureHighlightViewController);
	}
}
