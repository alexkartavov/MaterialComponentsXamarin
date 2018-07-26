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
	// @interface MDCMaskedTransitionController : NSObject <UIViewControllerTransitioningDelegate>
	[BaseType (typeof(NSObject))]
	interface MDCMaskedTransitionController : IUIViewControllerTransitioningDelegate
	{
		// -(instancetype _Nonnull)initWithSourceView:(UIView * _Nullable)sourceView;
		[Export ("initWithSourceView:")]
		IntPtr Constructor ([NullAllowed] UIView sourceView);
		// @property (readonly, nonatomic, strong) UIView * _Nullable sourceView;
		[NullAllowed, Export ("sourceView", ArgumentSemantic.Strong)]
		UIView SourceView { get; }
		// @property (copy, nonatomic) CGRect (^ _Nullable)(UIPresentationController * _Nonnull) calculateFrameOfPresentedView;
		[NullAllowed, Export ("calculateFrameOfPresentedView", ArgumentSemantic.Copy)]
		Func<UIPresentationController, CGRect> CalculateFrameOfPresentedView { get; set; }
	}
}
