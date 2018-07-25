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
	// @interface MDCFilledTextFieldColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCFilledTextFieldColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInputControllerFilled:(MDCTextInputControllerFilled * _Nonnull)textInputControllerFilled;
		[Static]
		[Export ("applySemanticColorScheme:toTextInputControllerFilled:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTextInputControllerFilled textInputControllerFilled);
	}
}
