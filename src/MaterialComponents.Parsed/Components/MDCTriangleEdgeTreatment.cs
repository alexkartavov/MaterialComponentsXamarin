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
	// @interface MDCTriangleEdgeTreatment : MDCEdgeTreatment
	[BaseType (typeof(MDCEdgeTreatment))]
	[DisableDefaultCtor]
	interface MDCTriangleEdgeTreatment
	{
		// @property (assign, nonatomic) CGFloat size;
		[Export ("size")]
		nfloat Size { get; set; }
		// @property (assign, nonatomic) MDCTriangleEdgeStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MDCTriangleEdgeStyle Style { get; set; }
		// -(instancetype _Nonnull)initWithSize:(CGFloat)size style:(MDCTriangleEdgeStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithSize:style:")]
		[DesignatedInitializer]
		IntPtr Constructor (nfloat size, MDCTriangleEdgeStyle style);
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}
}
