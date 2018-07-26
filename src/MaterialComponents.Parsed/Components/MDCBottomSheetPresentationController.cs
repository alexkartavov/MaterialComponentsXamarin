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
	// @interface MDCBottomSheetPresentationController : UIPresentationController
	[BaseType (typeof(UIPresentationController))]
	interface MDCBottomSheetPresentationController
	{
		// @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
		[NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
		UIScrollView TrackingScrollView { get; set; }
		// @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
		[Export ("dismissOnBackgroundTap")]
		bool DismissOnBackgroundTap { get; set; }
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MDCBottomSheetPresentationControllerDelegate Delegate { get; set; }
		// @property (nonatomic, weak) id<MDCBottomSheetPresentationControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}
}
