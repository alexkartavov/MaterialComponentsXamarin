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
	// @interface MDCCardsColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCCardsColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toCard:(MDCCard * _Nonnull)card;
		[Static]
		[Export ("applySemanticColorScheme:toCard:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCCard card);
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
		[Static]
		[Export ("applySemanticColorScheme:toCardCell:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCCardCollectionCell cardCell);
		// +(void)applyOutlinedVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toCard:(MDCCard * _Nonnull)card;
		[Static]
		[Export ("applyOutlinedVariantWithColorScheme:toCard:")]
		void ApplyOutlinedVariantWithColorScheme (MDCColorScheming colorScheme, MDCCard card);
		// +(void)applyOutlinedVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
		[Static]
		[Export ("applyOutlinedVariantWithColorScheme:toCardCell:")]
		void ApplyOutlinedVariantWithColorScheme (MDCColorScheming colorScheme, MDCCardCollectionCell cardCell);
	}
}
