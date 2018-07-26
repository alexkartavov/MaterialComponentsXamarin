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
	// @interface MDCChipViewColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCChipViewColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toChipView:(MDCChipView * _Nonnull)chipView;
		[Static]
		[Export ("applySemanticColorScheme:toChipView:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCChipView chipView);
		// +(void)applyOutlinedVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toChipView:(MDCChipView * _Nonnull)chipView;
		[Static]
		[Export ("applyOutlinedVariantWithColorScheme:toChipView:")]
		void ApplyOutlinedVariantWithColorScheme (MDCColorScheming colorScheme, MDCChipView chipView);
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toStrokedChipView:(MDCChipView * _Nonnull)strokedChipView;
		[Static]
		[Export ("applySemanticColorScheme:toStrokedChipView:")]
        void ApplySemanticColorScheme_toStrokedChipView (MDCColorScheming colorScheme, MDCChipView strokedChipView);
	}
}
