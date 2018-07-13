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
	// @interface MDCShapedShadowLayer : MDCShadowLayer
	[BaseType (typeof(MDCShadowLayer))]
	interface MDCShapedShadowLayer
	{
		// @property (nonatomic, strong) UIColor * _Nullable shapedBackgroundColor;
		[NullAllowed, Export ("shapedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ShapedBackgroundColor { get; set; }
		// @property (nonatomic, strong) UIColor * _Nullable shapedBorderColor;
		[NullAllowed, Export ("shapedBorderColor", ArgumentSemantic.Strong)]
		UIColor ShapedBorderColor { get; set; }
		// @property (assign, nonatomic) CGFloat shapedBorderWidth;
		[Export ("shapedBorderWidth")]
		nfloat ShapedBorderWidth { get; set; }
		// @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator;
		[NullAllowed, Export ("shapeGenerator", ArgumentSemantic.Strong)]
		MDCShapeGenerating ShapeGenerator { get; set; }
		// @property (nonatomic, strong) CAShapeLayer * _Nonnull shapeLayer;
		[Export ("shapeLayer", ArgumentSemantic.Strong)]
		CAShapeLayer ShapeLayer { get; set; }
		// @property (nonatomic, strong) CAShapeLayer * _Nonnull colorLayer;
		[Export ("colorLayer", ArgumentSemantic.Strong)]
		CAShapeLayer ColorLayer { get; set; }
	}
}
