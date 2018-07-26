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
	// @interface MDCButtonBarButton : MDCFlatButton
	[BaseType (typeof(MDCFlatButton))]
	interface MDCButtonBarButton
	{
		// -(void)setTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
		[Export ("setTitleFont:forState:")]
		void SetTitleFont ([NullAllowed] UIFont font, UIControlState state);
	}
}
