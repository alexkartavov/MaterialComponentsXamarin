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
	// @protocol MDCLeadingViewTextInput <MDCTextInput>
	[Protocol/*, Model*/]
	interface MDCLeadingViewTextInput : MDCTextInput
	{
		// @required @property (nonatomic, strong) UIView * _Nullable leadingView;
		[Abstract]
		[NullAllowed, Export ("leadingView", ArgumentSemantic.Strong)]
		UIView LeadingView { get; set; }
		// @required @property (assign, nonatomic) UITextFieldViewMode leadingViewMode;
		[Abstract]
		[Export ("leadingViewMode", ArgumentSemantic.Assign)]
		UITextFieldViewMode LeadingViewMode { get; set; }
	}
}
