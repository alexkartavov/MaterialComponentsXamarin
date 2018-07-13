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
	// @interface MDCTextInputBorderView : UIView <NSCopying>
	[BaseType (typeof(UIView))]
	interface MDCTextInputBorderView : INSCopying
	{
		// @property (nonatomic, strong) UIColor * _Nullable borderFillColor __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("borderFillColor", ArgumentSemantic.Strong)]
		UIColor BorderFillColor { get; set; }
		// @property (nonatomic, strong) UIBezierPath * _Nullable borderPath __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("borderPath", ArgumentSemantic.Strong)]
		UIBezierPath BorderPath { get; set; }
		// @property (nonatomic, strong) UIColor * _Nullable borderStrokeColor __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("borderStrokeColor", ArgumentSemantic.Strong)]
		UIColor BorderStrokeColor { get; set; }
	}
}
