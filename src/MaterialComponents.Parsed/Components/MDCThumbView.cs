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
	// @interface MDCThumbView : UIView
	[BaseType (typeof(UIView))]
	interface MDCThumbView
	{
		// @property (assign, nonatomic) BOOL hasShadow __attribute__((deprecated("Use `elevation` instead.")));
		[Export ("hasShadow")]
		bool HasShadow { get; set; }
		// @property (assign, nonatomic) MDCShadowElevation elevation;
		[Export ("elevation")]
		double Elevation { get; set; }
		// @property (assign, nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }
		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }
		// -(void)setIcon:(UIImage * _Nullable)icon;
		[Export ("setIcon:")]
		void SetIcon ([NullAllowed] UIImage icon);
	}
}
