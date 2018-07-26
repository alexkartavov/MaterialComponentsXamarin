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
	// @interface MDCCardReordering (UICollectionViewController) <UIGestureRecognizerDelegate>
	[Category]
	[BaseType (typeof(UICollectionViewController))]
	interface UICollectionViewController_MDCCardReordering : IUIGestureRecognizerDelegate
	{
		// -(void)mdc_setupCardReordering;
		[Export ("mdc_setupCardReordering")]
		void Mdc_setupCardReordering ();
	}
}
