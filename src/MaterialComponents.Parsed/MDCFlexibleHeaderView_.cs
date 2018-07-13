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
	// @interface  (MDCFlexibleHeaderView)
	[Category]
	[BaseType (typeof(MDCFlexibleHeaderView))]
	interface MDCFlexibleHeaderView_
	{
		// @property (nonatomic) MDCFlexibleHeaderShiftBehavior behavior __attribute__((deprecated("Use shiftBehavior instead.")));
		[Export ("behavior", ArgumentSemantic.Assign)]
		MDCFlexibleHeaderShiftBehavior Behavior { get; set; }
		// @property (nonatomic, strong) UIView * _Nonnull contentView __attribute__((deprecated("Please register views directly to the flexible header.")));
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }
	}
}
