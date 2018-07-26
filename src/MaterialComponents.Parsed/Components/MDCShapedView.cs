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
	// @interface MDCShapedView : UIView
	[BaseType (typeof(UIView))]
	interface MDCShapedView
	{
		// @property (assign, nonatomic) MDCShadowElevation elevation;
		[Export ("elevation")]
		double Elevation { get; set; }
		// @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator __attribute__((iboutlet));
		[NullAllowed, Export ("shapeGenerator", ArgumentSemantic.Strong)]
		MDCShapeGenerating ShapeGenerator { get; set; }
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame shapeGenerator:(id<MDCShapeGenerating> _Nullable)shapeGenerator __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:shapeGenerator:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame, [NullAllowed] MDCShapeGenerating shapeGenerator);
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nullable)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSCoder aDecoder);
	}
}
