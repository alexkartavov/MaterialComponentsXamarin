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
	// @interface MaterialTypography (UIFontDescriptor)
	[Category]
	[BaseType (typeof(UIFontDescriptor))]
	interface UIFontDescriptor_MaterialTypography
	{
		// +(UIFontDescriptor * _Nonnull)mdc_preferredFontDescriptorForMaterialTextStyle:(MDCFontTextStyle)style;
		//[Static]
		[Export ("mdc_preferredFontDescriptorForMaterialTextStyle:")]
		UIFontDescriptor Mdc_preferredFontDescriptorForMaterialTextStyle (MDCFontTextStyle style);
		// +(UIFontDescriptor * _Nonnull)mdc_standardFontDescriptorForMaterialTextStyle:(MDCFontTextStyle)style;
		//[Static]
		[Export ("mdc_standardFontDescriptorForMaterialTextStyle:")]
		UIFontDescriptor Mdc_standardFontDescriptorForMaterialTextStyle (MDCFontTextStyle style);
	}
}
