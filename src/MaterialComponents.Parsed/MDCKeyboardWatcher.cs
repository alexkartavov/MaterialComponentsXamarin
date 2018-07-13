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
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const MDCKeyboardWatcherKeyboardWillShowNotification;
		[Field ("MDCKeyboardWatcherKeyboardWillShowNotification", "__Internal")]
		NSString MDCKeyboardWatcherKeyboardWillShowNotification { get; }
		// extern NSString *const MDCKeyboardWatcherKeyboardWillHideNotification;
		[Field ("MDCKeyboardWatcherKeyboardWillHideNotification", "__Internal")]
		NSString MDCKeyboardWatcherKeyboardWillHideNotification { get; }
		// extern NSString *const MDCKeyboardWatcherKeyboardWillChangeFrameNotification;
		[Field ("MDCKeyboardWatcherKeyboardWillChangeFrameNotification", "__Internal")]
		NSString MDCKeyboardWatcherKeyboardWillChangeFrameNotification { get; }
	}
	// @interface MDCKeyboardWatcher : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCKeyboardWatcher
	{
		// +(instancetype)sharedKeyboardWatcher;
		[Static]
		[Export ("sharedKeyboardWatcher")]
		MDCKeyboardWatcher SharedKeyboardWatcher ();
		// +(NSTimeInterval)animationDurationFromKeyboardNotification:(NSNotification *)notification;
		[Static]
		[Export ("animationDurationFromKeyboardNotification:")]
		double AnimationDurationFromKeyboardNotification (NSNotification notification);
		// +(UIViewAnimationOptions)animationCurveOptionFromKeyboardNotification:(NSNotification *)notification;
		[Static]
		[Export ("animationCurveOptionFromKeyboardNotification:")]
		UIViewAnimationOptions AnimationCurveOptionFromKeyboardNotification (NSNotification notification);
		// @property (readonly, nonatomic) CGFloat visibleKeyboardHeight;
		[Export ("visibleKeyboardHeight")]
		nfloat VisibleKeyboardHeight { get; }
		// @property (readonly, nonatomic) CGFloat keyboardOffset __attribute__((deprecated("Use visibleKeyboardHeight instead of keyboardOffset")));
		[Export ("keyboardOffset")]
		nfloat KeyboardOffset { get; }
	}
}
