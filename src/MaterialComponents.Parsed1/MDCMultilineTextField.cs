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
	// @interface MDCMultilineTextField : UIView <MDCTextInput, MDCMultilineTextInput>
	[BaseType (typeof(UIView))]
	interface MDCMultilineTextField : MDCTextInput, MDCMultilineTextInput
	{
		// @property (assign, nonatomic) BOOL adjustsFontForContentSizeCategory;
		[Export ("adjustsFontForContentSizeCategory")]
		bool AdjustsFontForContentSizeCategory { get; set; }
		// @property (assign, nonatomic) BOOL expandsOnOverflow;
		[Export ("expandsOnOverflow")]
		new bool ExpandsOnOverflow { get; set; }
		[Wrap ("WeakLayoutDelegate")]
		[NullAllowed]
		MDCMultilineTextInputLayoutDelegate LayoutDelegate { get; set; }
		// @property (nonatomic, weak) id<MDCMultilineTextInputLayoutDelegate> _Nullable layoutDelegate __attribute__((iboutlet));
		[NullAllowed, Export ("layoutDelegate", ArgumentSemantic.Weak)]
		NSObject WeakLayoutDelegate { get; set; }
		[Wrap ("WeakMultilineDelegate")]
		[NullAllowed]
		MDCMultilineTextInputDelegate MultilineDelegate { get; set; }
		// @property (nonatomic, weak) id<MDCMultilineTextInputDelegate> _Nullable multilineDelegate __attribute__((iboutlet));
		[NullAllowed, Export ("multilineDelegate", ArgumentSemantic.Weak)]
		NSObject WeakMultilineDelegate { get; set; }
		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export ("placeholder")]
        new string Placeholder { get; set; }
		// @property (readonly, assign, nonatomic) UIEdgeInsets textInsets;
		[Export ("textInsets", ArgumentSemantic.Assign)]
        new UIEdgeInsets TextInsets { get; }
		// @property (nonatomic, strong) MDCIntrinsicHeightTextView * _Nullable textView __attribute__((iboutlet));
		[NullAllowed, Export ("textView", ArgumentSemantic.Strong)]
		MDCIntrinsicHeightTextView TextView { get; set; }
	}
}
