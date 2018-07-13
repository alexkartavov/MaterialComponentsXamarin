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
	// @interface  (MDCSnackbarMessageView)
	[Category]
	[BaseType (typeof(MDCSnackbarMessageView))]
	interface MDCSnackbarMessageView_
	{
		// @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewTextColor __attribute__((deprecated("Use messsageTextColor instead."))) __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("snackbarMessageViewTextColor", ArgumentSemantic.Strong)]
		UIColor SnackbarMessageViewTextColor { get; set; }
	}
}
