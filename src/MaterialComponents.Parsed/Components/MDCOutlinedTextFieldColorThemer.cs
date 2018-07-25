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
	// @interface MDCOutlinedTextFieldColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCOutlinedTextFieldColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
		[Static]
		[Export ("applySemanticColorScheme:toTextInputController:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTextInputController textInputController);
	}
}
