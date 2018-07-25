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
	// @protocol MDCTextInputCharacterCounter <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCTextInputCharacterCounter
	{
		// @required -(NSUInteger)characterCountForTextInput:(UIView<MDCTextInput> * _Nullable)textInput;
		[Abstract]
		[Export ("characterCountForTextInput:")]
		nuint CharacterCountForTextInput ([NullAllowed] MDCTextInput textInput);
	}
}
