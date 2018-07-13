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
	// @interface MDCFeatureHighlightFontThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCFeatureHighlightFontThemer
	{
		// +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toFeatureHighlightView:(MDCFeatureHighlightView * _Nonnull)featureHighlightView;
		[Static]
		[Export ("applyFontScheme:toFeatureHighlightView:")]
		void ApplyFontScheme (MDCFontScheme fontScheme, MDCFeatureHighlightView featureHighlightView);
	}
}
