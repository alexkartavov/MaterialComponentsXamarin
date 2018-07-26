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
	// @protocol MDCBottomSheetControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCBottomSheetControllerDelegate
	{
		// @required -(void)bottomSheetControllerDidDismissBottomSheet:(MDCBottomSheetController * _Nonnull)controller;
		[Abstract]
		[Export ("bottomSheetControllerDidDismissBottomSheet:")]
		void BottomSheetControllerDidDismissBottomSheet (MDCBottomSheetController controller);
	}
}
