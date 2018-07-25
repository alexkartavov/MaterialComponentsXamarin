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
	// @protocol MDCMultilineTextInputLayoutDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCMultilineTextInputLayoutDelegate
	{
		// @optional -(void)multilineTextField:(id<MDCMultilineTextInput> _Nonnull)multilineTextField didChangeContentSize:(CGSize)size;
		[Export ("multilineTextField:didChangeContentSize:")]
		void DidChangeContentSize (MDCMultilineTextInput multilineTextField, CGSize size);
	}
}
