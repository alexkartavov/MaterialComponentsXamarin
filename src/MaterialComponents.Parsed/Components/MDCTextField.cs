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
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull MDCTextFieldTextDidSetTextNotification;
		[Field ("MDCTextFieldTextDidSetTextNotification", "__Internal")]
		NSString MDCTextFieldTextDidSetTextNotification { get; }
	}
	// @interface MDCTextField : UITextField <MDCTextInput>
	[BaseType (typeof(UITextField))]
	interface MDCTextField : MDCTextInput
	{
		// @property (nonatomic, strong) UIView * _Nullable leadingView;
		[NullAllowed, Export ("leadingView", ArgumentSemantic.Strong)]
		UIView LeadingView { get; set; }
		// @property (assign, nonatomic) UITextFieldViewMode leadingViewMode;
		[Export ("leadingViewMode", ArgumentSemantic.Assign)]
		UITextFieldViewMode LeadingViewMode { get; set; }
	}
}
