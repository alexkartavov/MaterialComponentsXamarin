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
	// @interface MaterialBottomSheet (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_MaterialBottomSheet
	{
		// @property (readonly, nonatomic) MDCBottomSheetPresentationController * _Nullable mdc_bottomSheetPresentationController;
		[NullAllowed, Export ("mdc_bottomSheetPresentationController")]
		MDCBottomSheetPresentationController Mdc_bottomSheetPresentationController { get; }
	}
}
