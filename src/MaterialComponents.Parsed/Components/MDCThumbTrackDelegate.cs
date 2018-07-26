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
	// @protocol MDCThumbTrackDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCThumbTrackDelegate
	{
		// @optional -(NSString * _Nonnull)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack stringForValue:(CGFloat)value;
		[Export ("thumbTrack:stringForValue:")]
		string ThumbTrack (MDCThumbTrack thumbTrack, nfloat value);
		// @optional -(BOOL)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack shouldJumpToValue:(CGFloat)value;
		[Export ("thumbTrack:shouldJumpToValue:")]
        bool ThumbTrack_shouldJumpToValue (MDCThumbTrack thumbTrack, nfloat value);
		// @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack willJumpToValue:(CGFloat)value;
		[Export ("thumbTrack:willJumpToValue:")]
        void ThumbTrack_willJumpToValue (MDCThumbTrack thumbTrack, nfloat value);
		// @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack willAnimateToValue:(CGFloat)value;
		[Export ("thumbTrack:willAnimateToValue:")]
        void ThumbTrack_willAnimateToValue (MDCThumbTrack thumbTrack, nfloat value);
		// @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack didAnimateToValue:(CGFloat)value;
		[Export ("thumbTrack:didAnimateToValue:")]
        void ThumbTrack_didAnimateToValue (MDCThumbTrack thumbTrack, nfloat value);
	}
}
