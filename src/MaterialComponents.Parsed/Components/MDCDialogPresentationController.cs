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
	// @interface MDCDialogPresentationController : UIPresentationController
	[BaseType (typeof(UIPresentationController))]
	interface MDCDialogPresentationController
	{
		// @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
		[Export ("dismissOnBackgroundTap")]
		bool DismissOnBackgroundTap { get; set; }
		// -(CGSize)sizeForChildContentContainer:(id<UIContentContainer> _Nonnull)container withParentContainerSize:(CGSize)parentSize;
		[Export ("sizeForChildContentContainer:withParentContainerSize:")]
		CGSize SizeForChildContentContainer (UIContentContainer container, CGSize parentSize);
		// -(CGRect)frameOfPresentedViewInContainerView;
		[Export ("frameOfPresentedViewInContainerView")]
		//[Verify (MethodToProperty)]
        CGRect FrameOfPresentedViewInContainerView();
	}
}
