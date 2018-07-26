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
	// @interface MDCBottomSheetTransitionController : NSObject <UIViewControllerAnimatedTransitioning, UIViewControllerTransitioningDelegate>
	[BaseType (typeof(NSObject))]
	interface MDCBottomSheetTransitionController : IUIViewControllerAnimatedTransitioning, IUIViewControllerTransitioningDelegate
	{
		// @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
		[NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
		UIScrollView TrackingScrollView { get; set; }
		// @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
		[Export ("dismissOnBackgroundTap")]
		bool DismissOnBackgroundTap { get; set; }
	}
}
