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
	// @interface MDCShadowMetrics : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCShadowMetrics
	{
		// @property (readonly, nonatomic) CGFloat topShadowRadius;
		[Export ("topShadowRadius")]
		nfloat TopShadowRadius { get; }
		// @property (readonly, nonatomic) CGSize topShadowOffset;
		[Export ("topShadowOffset")]
		CGSize TopShadowOffset { get; }
		// @property (readonly, nonatomic) float topShadowOpacity;
		[Export ("topShadowOpacity")]
		float TopShadowOpacity { get; }
		// @property (readonly, nonatomic) CGFloat bottomShadowRadius;
		[Export ("bottomShadowRadius")]
		nfloat BottomShadowRadius { get; }
		// @property (readonly, nonatomic) CGSize bottomShadowOffset;
		[Export ("bottomShadowOffset")]
		CGSize BottomShadowOffset { get; }
		// @property (readonly, nonatomic) float bottomShadowOpacity;
		[Export ("bottomShadowOpacity")]
		float BottomShadowOpacity { get; }
		// +(MDCShadowMetrics * _Nonnull)metricsWithElevation:(CGFloat)elevation;
		[Static]
		[Export ("metricsWithElevation:")]
		MDCShadowMetrics MetricsWithElevation (nfloat elevation);
	}
}
