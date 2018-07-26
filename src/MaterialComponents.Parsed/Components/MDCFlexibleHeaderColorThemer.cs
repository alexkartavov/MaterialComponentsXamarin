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
	// @interface MDCFlexibleHeaderColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCFlexibleHeaderColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
		[Static]
		[Export ("applySemanticColorScheme:toFlexibleHeaderView:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCFlexibleHeaderView flexibleHeaderView);
		// +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
		[Static]
		[Export ("applySurfaceVariantWithColorScheme:toFlexibleHeaderView:")]
		void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCFlexibleHeaderView flexibleHeaderView);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
		[Static]
		[Export ("applyColorScheme:toFlexibleHeaderView:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCFlexibleHeaderView flexibleHeaderView);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toMDCFlexibleHeaderController:(MDCFlexibleHeaderViewController * _Nonnull)flexibleHeaderController;
		[Static]
		[Export ("applyColorScheme:toMDCFlexibleHeaderController:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCFlexibleHeaderViewController flexibleHeaderController);
	}
}
