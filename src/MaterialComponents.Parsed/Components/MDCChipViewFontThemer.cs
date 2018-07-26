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
	// @interface MDCChipViewFontThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCChipViewFontThemer
	{
		// +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toChipView:(MDCChipView * _Nonnull)chipView;
		[Static]
		[Export ("applyFontScheme:toChipView:")]
		void ApplyFontScheme (MDCFontScheme fontScheme, MDCChipView chipView);
	}
}
