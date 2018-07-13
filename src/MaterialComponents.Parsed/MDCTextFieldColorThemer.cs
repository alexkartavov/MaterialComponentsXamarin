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
	// @interface MDCTextFieldColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCTextFieldColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
		[Static]
		[Export ("applySemanticColorScheme:toTextInputController:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTextInputController textInputController);
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass;
		[Static]
		[Export ("applySemanticColorScheme:toAllTextInputControllersOfClass:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTextInputController textInputControllerClass);
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInput:(id<MDCTextInput> _Nonnull)textInput;
		[Static]
		[Export ("applySemanticColorScheme:toTextInput:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTextInput textInput);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
		[Static]
		[Export ("applyColorScheme:toTextInputController:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCTextInputController textInputController);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass;
		[Static]
		[Export ("applyColorScheme:toAllTextInputControllersOfClass:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCTextInputController textInputControllerClass);
	}
}
