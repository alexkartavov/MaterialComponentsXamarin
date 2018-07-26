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
	// @interface MDCFlexibleHeaderContainerViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MDCFlexibleHeaderContainerViewController
	{
		// -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nullable)contentViewController __attribute__((objc_designated_initializer));
		[Export ("initWithContentViewController:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIViewController contentViewController);
		// @property (readonly, nonatomic, strong) MDCFlexibleHeaderViewController * _Nonnull headerViewController;
		[Export ("headerViewController", ArgumentSemantic.Strong)]
		MDCFlexibleHeaderViewController HeaderViewController { get; }
		// @property (nonatomic, strong) UIViewController * _Nullable contentViewController;
		[NullAllowed, Export ("contentViewController", ArgumentSemantic.Strong)]
		UIViewController ContentViewController { get; set; }
	}
}
