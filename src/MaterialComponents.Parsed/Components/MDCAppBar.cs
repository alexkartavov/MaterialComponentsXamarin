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
	// @interface MDCAppBar : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCAppBar
	{
		// -(void)addSubviewsToParent;
		[Export ("addSubviewsToParent")]
		void AddSubviewsToParent ();
		// @property (readonly, nonatomic, strong) MDCFlexibleHeaderViewController * _Nonnull headerViewController;
		[Export ("headerViewController", ArgumentSemantic.Strong)]
		MDCFlexibleHeaderViewController HeaderViewController { get; }
		// @property (readonly, nonatomic, strong) MDCNavigationBar * _Nonnull navigationBar;
		[Export ("navigationBar", ArgumentSemantic.Strong)]
		MDCNavigationBar NavigationBar { get; }
		// @property (readonly, nonatomic, strong) MDCHeaderStackView * _Nonnull headerStackView;
		[Export ("headerStackView", ArgumentSemantic.Strong)]
		MDCHeaderStackView HeaderStackView { get; }
	}
}
