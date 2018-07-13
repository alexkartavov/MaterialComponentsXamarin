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
	// @interface MDCBottomSheetController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MDCBottomSheetController
	{
		// @property (readonly, nonatomic, strong) UIViewController * _Nonnull contentViewController;
		[Export ("contentViewController", ArgumentSemantic.Strong)]
		UIViewController ContentViewController { get; }
		// @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
		[NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
		UIScrollView TrackingScrollView { get; set; }
		// @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
		[Export ("dismissOnBackgroundTap")]
		bool DismissOnBackgroundTap { get; set; }
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MDCBottomSheetControllerDelegate Delegate { get; set; }
		// @property (nonatomic, weak) id<MDCBottomSheetControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
		// -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nonnull)contentViewController;
		[Export ("initWithContentViewController:")]
		IntPtr Constructor (UIViewController contentViewController);
	}
}
