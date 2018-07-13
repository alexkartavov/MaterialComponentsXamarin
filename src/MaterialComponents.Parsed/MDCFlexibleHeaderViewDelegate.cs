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
	// @protocol MDCFlexibleHeaderViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCFlexibleHeaderViewDelegate
	{
		// @required -(void)flexibleHeaderViewNeedsStatusBarAppearanceUpdate:(MDCFlexibleHeaderView * _Nonnull)headerView;
		[Abstract]
		[Export ("flexibleHeaderViewNeedsStatusBarAppearanceUpdate:")]
		void FlexibleHeaderViewNeedsStatusBarAppearanceUpdate (MDCFlexibleHeaderView headerView);
		// @required -(void)flexibleHeaderViewFrameDidChange:(MDCFlexibleHeaderView * _Nonnull)headerView;
		[Abstract]
		[Export ("flexibleHeaderViewFrameDidChange:")]
		void FlexibleHeaderViewFrameDidChange (MDCFlexibleHeaderView headerView);
	}
}
