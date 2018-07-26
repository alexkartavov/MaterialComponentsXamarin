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
	// @interface MDCShadowLayer : CALayer
	[BaseType (typeof(CALayer))]
	interface MDCShadowLayer
	{
		// @property (assign, nonatomic) MDCShadowElevation elevation;
		[Export ("elevation")]
		double Elevation { get; set; }
		// @property (getter = isShadowMaskEnabled, assign, nonatomic) BOOL shadowMaskEnabled;
		[Export ("shadowMaskEnabled")]
		bool ShadowMaskEnabled { [Bind ("isShadowMaskEnabled")] get; set; }
	}
}
