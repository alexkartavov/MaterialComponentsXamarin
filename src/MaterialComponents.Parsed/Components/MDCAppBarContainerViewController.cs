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
	// @interface MDCAppBarContainerViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	[DisableDefaultCtor]
	interface MDCAppBarContainerViewController
	{
		// -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nonnull)contentViewController __attribute__((objc_designated_initializer));
		[Export ("initWithContentViewController:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIViewController contentViewController);
		// @property (readonly, nonatomic, strong) MDCAppBar * _Nonnull appBar;
		[Export ("appBar", ArgumentSemantic.Strong)]
		MDCAppBar AppBar { get; }
		// @property (readonly, nonatomic, strong) UIViewController * _Nonnull contentViewController;
		[Export ("contentViewController", ArgumentSemantic.Strong)]
		UIViewController ContentViewController { get; }
	}
}
