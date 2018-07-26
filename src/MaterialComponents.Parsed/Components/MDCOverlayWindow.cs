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
	// @interface MDCOverlayWindow : UIWindow
	[BaseType (typeof(UIWindow))]
	interface MDCOverlayWindow
	{
		// -(void)activateOverlay:(UIView *)overlay withLevel:(UIWindowLevel)level;
		[Export ("activateOverlay:withLevel:")]
		void ActivateOverlay (UIView overlay, double level);
		// -(void)deactivateOverlay:(UIView *)overlay;
		[Export ("deactivateOverlay:")]
		void DeactivateOverlay (UIView overlay);
	}
}
