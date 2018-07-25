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
	// @interface MDCTextButtonColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCTextButtonColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
		[Static]
		[Export ("applySemanticColorScheme:toButton:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCButton button);
	}
}
