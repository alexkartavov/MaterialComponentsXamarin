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
	// @protocol MDCFlexibleHeaderViewLayoutDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCFlexibleHeaderViewLayoutDelegate
	{
		// @required -(void)flexibleHeaderViewController:(MDCFlexibleHeaderViewController * _Nonnull)flexibleHeaderViewController flexibleHeaderViewFrameDidChange:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
		[Abstract]
		[Export ("flexibleHeaderViewController:flexibleHeaderViewFrameDidChange:")]
		void FlexibleHeaderViewFrameDidChange (MDCFlexibleHeaderViewController flexibleHeaderViewController, MDCFlexibleHeaderView flexibleHeaderView);
	}
}
