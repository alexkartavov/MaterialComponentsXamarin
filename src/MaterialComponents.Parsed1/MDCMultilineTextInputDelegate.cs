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
	// @protocol MDCMultilineTextInputDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCMultilineTextInputDelegate
	{
		// @optional -(BOOL)multilineTextFieldShouldClear:(UIView<MDCTextInput> *)textField;
		[Export ("multilineTextFieldShouldClear:")]
		bool MultilineTextFieldShouldClear (MDCTextInput textField);
	}
}
