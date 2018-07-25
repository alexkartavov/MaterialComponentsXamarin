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
	// @interface MDCTextFieldFontThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCTextFieldFontThemer
	{
		// +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
		[Static]
		[Export ("applyFontScheme:toTextInputController:")]
		void ApplyFontScheme (MDCFontScheme fontScheme, MDCTextInputController textInputController);
		// +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass;
		[Static]
		[Export ("applyFontScheme:toAllTextInputControllersOfClass:")]
        void ApplyFontScheme_ToAllTextInputControllersOfClass (MDCFontScheme fontScheme, MDCTextInputController textInputControllerClass);
		// +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTextField:(MDCTextField * _Nullable)textField;
		[Static]
		[Export ("applyFontScheme:toTextField:")]
        void ApplyFontScheme_ToTextField (MDCFontScheme fontScheme, [NullAllowed] MDCTextField textField);
	}
}
