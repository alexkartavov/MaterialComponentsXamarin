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
	// @interface MDCSlantedRectShapeGenerator : NSObject <MDCShapeGenerating>
	[BaseType (typeof(NSObject))]
	interface MDCSlantedRectShapeGenerator : MDCShapeGenerating
	{
		// @property (assign, nonatomic) CGFloat slant;
		[Export ("slant")]
		nfloat Slant { get; set; }
	}
}
