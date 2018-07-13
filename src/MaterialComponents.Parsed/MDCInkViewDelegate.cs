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
	// @protocol MDCInkViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCInkViewDelegate
	{
		// @optional -(void)inkAnimationDidStart:(MDCInkView * _Nonnull)inkView;
		[Export ("inkAnimationDidStart:")]
		void InkAnimationDidStart (MDCInkView inkView);
		// @optional -(void)inkAnimationDidEnd:(MDCInkView * _Nonnull)inkView;
		[Export ("inkAnimationDidEnd:")]
		void InkAnimationDidEnd (MDCInkView inkView);
	}
}
