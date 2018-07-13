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
	// @interface MaterialTypography (UIFont)
	[Category]
	[BaseType (typeof(UIFont))]
	interface UIFont_MaterialTypography
	{
		// +(UIFont * _Nonnull)mdc_preferredFontForMaterialTextStyle:(MDCFontTextStyle)style;
		[Static]
		[Export ("mdc_preferredFontForMaterialTextStyle:")]
		UIFont Mdc_preferredFontForMaterialTextStyle (MDCFontTextStyle style);
		// +(UIFont * _Nonnull)mdc_standardFontForMaterialTextStyle:(MDCFontTextStyle)style;
		[Static]
		[Export ("mdc_standardFontForMaterialTextStyle:")]
		UIFont Mdc_standardFontForMaterialTextStyle (MDCFontTextStyle style);
		// -(UIFont * _Nonnull)mdc_fontSizedForMaterialTextStyle:(MDCFontTextStyle)style scaledForDynamicType:(BOOL)scaled;
		[Export ("mdc_fontSizedForMaterialTextStyle:scaledForDynamicType:")]
		UIFont Mdc_fontSizedForMaterialTextStyle (MDCFontTextStyle style, bool scaled);
	}
}
