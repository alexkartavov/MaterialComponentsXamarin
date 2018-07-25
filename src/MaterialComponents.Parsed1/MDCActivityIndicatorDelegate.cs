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
	// @protocol MDCActivityIndicatorDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCActivityIndicatorDelegate
	{
		// @optional -(void)activityIndicatorAnimationDidFinish:(MDCActivityIndicator * _Nonnull)activityIndicator;
		[Export ("activityIndicatorAnimationDidFinish:")]
		void ActivityIndicatorAnimationDidFinish (MDCActivityIndicator activityIndicator);
		// @optional -(void)activityIndicatorModeTransitionDidFinish:(MDCActivityIndicator * _Nonnull)activityIndicator;
		[Export ("activityIndicatorModeTransitionDidFinish:")]
		void ActivityIndicatorModeTransitionDidFinish (MDCActivityIndicator activityIndicator);
	}
}
