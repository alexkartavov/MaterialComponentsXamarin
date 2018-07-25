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
	// typedef void (^MDCActivityIndicatorAnimation)(CGFloat, CGFloat);
	delegate void MDCActivityIndicatorAnimation (nfloat arg0, nfloat arg1);
	// @interface MDCActivityIndicatorTransition : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MDCActivityIndicatorTransition
	{
		// @property (copy, nonatomic) MDCActivityIndicatorAnimation _Nonnull animation;
		[Export ("animation", ArgumentSemantic.Copy)]
		MDCActivityIndicatorAnimation Animation { get; set; }
		// @property (copy, nonatomic) void (^ _Nullable)(void) completion;
		[NullAllowed, Export ("completion", ArgumentSemantic.Copy)]
		Action Completion { get; set; }
		// @property (assign, nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; set; }
		// -(instancetype _Nonnull)initWithAnimation:(MDCActivityIndicatorAnimation _Nonnull)animation __attribute__((objc_designated_initializer));
		[Export ("initWithAnimation:")]
		[DesignatedInitializer]
		IntPtr Constructor (MDCActivityIndicatorAnimation animation);
	}
}
