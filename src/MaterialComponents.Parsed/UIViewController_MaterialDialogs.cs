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
	// @interface MaterialDialogs (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_MaterialDialogs
	{
		// @property (readonly, nonatomic) MDCDialogPresentationController * _Nullable mdc_dialogPresentationController;
		[NullAllowed, Export ("mdc_dialogPresentationController")]
		MDCDialogPresentationController Mdc_dialogPresentationController { get; }
	}
}
