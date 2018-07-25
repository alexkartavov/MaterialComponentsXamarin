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
	// @interface MDCFloatingButtonColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCFloatingButtonColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCFloatingButton * _Nonnull)button;
		[Static]
		[Export ("applySemanticColorScheme:toButton:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCFloatingButton button);
	}
}
