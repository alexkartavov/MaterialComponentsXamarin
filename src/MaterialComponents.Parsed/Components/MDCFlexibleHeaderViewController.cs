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
	// @interface MDCFlexibleHeaderViewController : UIViewController <UIScrollViewDelegate, UITableViewDelegate>
	[BaseType (typeof(UIViewController))]
	interface MDCFlexibleHeaderViewController : IUIScrollViewDelegate, IUITableViewDelegate
	{
		// @property (readonly, nonatomic, strong) MDCFlexibleHeaderView * _Nonnull headerView;
		[Export ("headerView", ArgumentSemantic.Strong)]
		MDCFlexibleHeaderView HeaderView { get; }
		[Wrap ("WeakLayoutDelegate")]
		[NullAllowed]
		MDCFlexibleHeaderViewLayoutDelegate LayoutDelegate { get; set; }
		// @property (nonatomic, weak) id<MDCFlexibleHeaderViewLayoutDelegate> _Nullable layoutDelegate;
		[NullAllowed, Export ("layoutDelegate", ArgumentSemantic.Weak)]
		NSObject WeakLayoutDelegate { get; set; }
        // -(BOOL)prefersStatusBarHidden;
        [Export("prefersStatusBarHidden")]
        //[Verify (MethodToProperty)]
        bool PrefersStatusBarHidden();
        // -(UIStatusBarStyle)preferredStatusBarStyle;
        [Export("preferredStatusBarStyle")]
        //[Verify (MethodToProperty)]
        UIStatusBarStyle PreferredStatusBarStyle();
		// -(void)updateTopLayoutGuide;
		[Export ("updateTopLayoutGuide")]
		void UpdateTopLayoutGuide ();
	}
}
