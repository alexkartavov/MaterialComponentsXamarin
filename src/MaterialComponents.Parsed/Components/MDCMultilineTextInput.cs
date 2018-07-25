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
	// @protocol MDCMultilineTextInput <MDCTextInput>
	[Protocol, Model]
    [BaseType(typeof(NSObject))]
	interface MDCMultilineTextInput : MDCTextInput
	{
		// @required @property (assign, nonatomic) BOOL expandsOnOverflow;
		[Abstract]
		[Export ("expandsOnOverflow")]
		bool ExpandsOnOverflow { get; set; }
		// @required @property (assign, nonatomic) NSUInteger minimumLines __attribute__((annotate("ui_appearance_selector")));
		[Abstract]
		[Export ("minimumLines")]
		nuint MinimumLines { get; set; }
	}
}
