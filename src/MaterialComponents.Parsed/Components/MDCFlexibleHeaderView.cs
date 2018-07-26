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
	// typedef void (^MDCFlexibleHeaderChangeContentInsetsBlock)();
	delegate void MDCFlexibleHeaderChangeContentInsetsBlock ();
	// typedef void (^MDCFlexibleHeaderShadowIntensityChangeBlock)(CALayer * _Nonnull, CGFloat);
	delegate void MDCFlexibleHeaderShadowIntensityChangeBlock (CALayer arg0, nfloat arg1);
	// @interface MDCFlexibleHeaderView : UIView
	[BaseType (typeof(UIView))]
	interface MDCFlexibleHeaderView
	{
		// @property (nonatomic, strong) CALayer * _Nullable shadowLayer;
		[NullAllowed, Export ("shadowLayer", ArgumentSemantic.Strong)]
		CALayer ShadowLayer { get; set; }
		// -(void)setShadowLayer:(CALayer * _Nonnull)shadowLayer intensityDidChangeBlock:(MDCFlexibleHeaderShadowIntensityChangeBlock _Nonnull)block;
		[Export ("setShadowLayer:intensityDidChangeBlock:")]
		void SetShadowLayer (CALayer shadowLayer, MDCFlexibleHeaderShadowIntensityChangeBlock block);
		// -(void)trackingScrollViewDidScroll;
		[Export ("trackingScrollViewDidScroll")]
		void TrackingScrollViewDidScroll ();
		// -(void)trackingScrollViewDidEndDraggingWillDecelerate:(BOOL)willDecelerate;
		[Export ("trackingScrollViewDidEndDraggingWillDecelerate:")]
		void TrackingScrollViewDidEndDraggingWillDecelerate (bool willDecelerate);
		// -(void)trackingScrollViewDidEndDecelerating;
		[Export ("trackingScrollViewDidEndDecelerating")]
		void TrackingScrollViewDidEndDecelerating ();
		// -(BOOL)trackingScrollViewWillEndDraggingWithVelocity:(CGPoint)velocity targetContentOffset:(CGPoint * _Nonnull)targetContentOffset;
		//[Export ("trackingScrollViewWillEndDraggingWithVelocity:targetContentOffset:")]
		//unsafe bool TrackingScrollViewWillEndDraggingWithVelocity (CGPoint velocity, CGPoint* targetContentOffset);
		// -(void)trackingScrollWillChangeToScrollView:(UIScrollView * _Nullable)scrollView;
		[Export ("trackingScrollWillChangeToScrollView:")]
		void TrackingScrollWillChangeToScrollView ([NullAllowed] UIScrollView scrollView);
		// -(void)shiftHeaderOnScreenAnimated:(BOOL)animated;
		[Export ("shiftHeaderOnScreenAnimated:")]
		void ShiftHeaderOnScreenAnimated (bool animated);
		// -(void)shiftHeaderOffScreenAnimated:(BOOL)animated;
		[Export ("shiftHeaderOffScreenAnimated:")]
		void ShiftHeaderOffScreenAnimated (bool animated);
		// @property (readonly, nonatomic) BOOL prefersStatusBarHidden;
		[Export ("prefersStatusBarHidden")]
		bool PrefersStatusBarHidden { get; }
		// -(void)interfaceOrientationWillChange;
		[Export ("interfaceOrientationWillChange")]
		void InterfaceOrientationWillChange ();
		// -(void)interfaceOrientationIsChanging;
		[Export ("interfaceOrientationIsChanging")]
		void InterfaceOrientationIsChanging ();
		// -(void)interfaceOrientationDidChange;
		[Export ("interfaceOrientationDidChange")]
		void InterfaceOrientationDidChange ();
		// -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
		//[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		//void ViewWillTransitionToSize (CGSize size, UIViewControllerTransitionCoordinator coordinator);
		// -(void)changeContentInsets:(MDCFlexibleHeaderChangeContentInsetsBlock _Nonnull)block;
		[Export ("changeContentInsets:")]
		void ChangeContentInsets (MDCFlexibleHeaderChangeContentInsetsBlock block);
		// -(void)forwardTouchEventsForView:(UIView * _Nonnull)view;
		[Export ("forwardTouchEventsForView:")]
		void ForwardTouchEventsForView (UIView view);
		// -(void)stopForwardingTouchEventsForView:(UIView * _Nonnull)view;
		[Export ("stopForwardingTouchEventsForView:")]
		void StopForwardingTouchEventsForView (UIView view);
		// @property (readonly, nonatomic) MDCFlexibleHeaderScrollPhase scrollPhase;
		[Export ("scrollPhase")]
		MDCFlexibleHeaderScrollPhase ScrollPhase { get; }
		// @property (readonly, nonatomic) CGFloat scrollPhaseValue;
		[Export ("scrollPhaseValue")]
		nfloat ScrollPhaseValue { get; }
		// @property (readonly, nonatomic) CGFloat scrollPhasePercentage;
		[Export ("scrollPhasePercentage")]
		nfloat ScrollPhasePercentage { get; }
		// @property (nonatomic) CGFloat minimumHeight;
		[Export ("minimumHeight")]
		nfloat MinimumHeight { get; set; }
		// @property (nonatomic) CGFloat maximumHeight;
		[Export ("maximumHeight")]
		nfloat MaximumHeight { get; set; }
		// @property (nonatomic) BOOL minMaxHeightIncludesSafeArea;
		[Export ("minMaxHeightIncludesSafeArea")]
		bool MinMaxHeightIncludesSafeArea { get; set; }
		// @property (nonatomic) MDCFlexibleHeaderShiftBehavior shiftBehavior;
		[Export ("shiftBehavior", ArgumentSemantic.Assign)]
		MDCFlexibleHeaderShiftBehavior ShiftBehavior { get; set; }
		// -(void)hideViewWhenShifted:(UIView * _Nonnull)view;
		[Export ("hideViewWhenShifted:")]
		void HideViewWhenShifted (UIView view);
		// -(void)stopHidingViewWhenShifted:(UIView * _Nonnull)view;
		[Export ("stopHidingViewWhenShifted:")]
		void StopHidingViewWhenShifted (UIView view);
		// @property (nonatomic) MDCFlexibleHeaderContentImportance headerContentImportance;
		[Export ("headerContentImportance", ArgumentSemantic.Assign)]
		MDCFlexibleHeaderContentImportance HeaderContentImportance { get; set; }
		// @property (nonatomic) BOOL canOverExtend;
		[Export ("canOverExtend")]
		bool CanOverExtend { get; set; }
		// @property (nonatomic) BOOL statusBarHintCanOverlapHeader;
		[Export ("statusBarHintCanOverlapHeader")]
		bool StatusBarHintCanOverlapHeader { get; set; }
		// @property (nonatomic) float visibleShadowOpacity;
		[Export ("visibleShadowOpacity")]
		float VisibleShadowOpacity { get; set; }
		// @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
		[NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
		UIScrollView TrackingScrollView { get; set; }
		// @property (nonatomic) BOOL trackingScrollViewIsBeingScrubbed;
		[Export ("trackingScrollViewIsBeingScrubbed")]
		bool TrackingScrollViewIsBeingScrubbed { get; set; }
		// @property (getter = isInFrontOfInfiniteContent, nonatomic) BOOL inFrontOfInfiniteContent;
		[Export ("inFrontOfInfiniteContent")]
		bool InFrontOfInfiniteContent { [Bind ("isInFrontOfInfiniteContent")] get; set; }
		// @property (nonatomic) BOOL sharedWithManyScrollViews;
		[Export ("sharedWithManyScrollViews")]
		bool SharedWithManyScrollViews { get; set; }
		// @property (nonatomic) BOOL contentIsTranslucent;
		[Export ("contentIsTranslucent")]
		bool ContentIsTranslucent { get; set; }
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MDCFlexibleHeaderViewDelegate Delegate { get; set; }
		// @property (nonatomic, weak) id<MDCFlexibleHeaderViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}
}
