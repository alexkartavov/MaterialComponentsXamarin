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
	// @interface MDCChipViewTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCChipViewTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toChipView:(MDCChipView * _Nonnull)chipView;
		[Static]
		[Export ("applyTypographyScheme:toChipView:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCChipView chipView);
	}
}
