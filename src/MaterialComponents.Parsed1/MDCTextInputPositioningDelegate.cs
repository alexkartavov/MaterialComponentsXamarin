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
	// @protocol MDCTextInputPositioningDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCTextInputPositioningDelegate
	{
		// @optional -(UIEdgeInsets)textInsets:(UIEdgeInsets)defaultInsets;
		[Export ("textInsets:")]
		UIEdgeInsets TextInsets (UIEdgeInsets defaultInsets);
		// @optional -(CGRect)editingRectForBounds:(CGRect)bounds defaultRect:(CGRect)defaultRect;
		[Export ("editingRectForBounds:defaultRect:")]
		CGRect EditingRectForBounds (CGRect bounds, CGRect defaultRect);
		// @optional -(void)textInputDidLayoutSubviews;
		[Export ("textInputDidLayoutSubviews")]
		void TextInputDidLayoutSubviews ();
		// @optional -(void)textInputDidUpdateConstraints;
		[Export ("textInputDidUpdateConstraints")]
		void TextInputDidUpdateConstraints ();
	}
}
