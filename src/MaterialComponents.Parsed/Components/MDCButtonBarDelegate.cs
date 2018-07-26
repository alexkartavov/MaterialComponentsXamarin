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
	// @protocol MDCButtonBarDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCButtonBarDelegate
	{
		// @required -(UIView * _Nonnull)buttonBar:(MDCButtonBar * _Nonnull)buttonBar viewForItem:(UIBarButtonItem * _Nonnull)barButtonItem layoutHints:(MDCBarButtonItemLayoutHints)layoutHints;
		[Abstract]
		[Export ("buttonBar:viewForItem:layoutHints:")]
		UIView ViewForItem (MDCButtonBar buttonBar, UIBarButtonItem barButtonItem, MDCBarButtonItemLayoutHints layoutHints);
	}
}
