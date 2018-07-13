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
	// @protocol MDCBottomSheetPresentationControllerDelegate <UIAdaptivePresentationControllerDelegate>
	[Protocol, Model]
	interface MDCBottomSheetPresentationControllerDelegate : IUIAdaptivePresentationControllerDelegate
	{
		// @optional -(void)prepareForBottomSheetPresentation:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet;
		[Export ("prepareForBottomSheetPresentation:")]
		void PrepareForBottomSheetPresentation (MDCBottomSheetPresentationController bottomSheet);
		// @optional -(void)bottomSheetPresentationControllerDidDismissBottomSheet:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet;
		[Export ("bottomSheetPresentationControllerDidDismissBottomSheet:")]
		void BottomSheetPresentationControllerDidDismissBottomSheet (MDCBottomSheetPresentationController bottomSheet);
	}
}
