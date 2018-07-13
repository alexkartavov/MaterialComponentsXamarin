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
	// @interface MDCFeatureHighlightView : UIView
	[BaseType (typeof(UIView))]
	interface MDCFeatureHighlightView
	{
		// @property (nonatomic, strong) UIColor * _Nullable innerHighlightColor __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("innerHighlightColor", ArgumentSemantic.Strong)]
		UIColor InnerHighlightColor { get; set; }
		// @property (nonatomic, strong) UIColor * _Nullable outerHighlightColor __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("outerHighlightColor", ArgumentSemantic.Strong)]
		UIColor OuterHighlightColor { get; set; }
		// @property (nonatomic, strong) UIFont * _Nullable titleFont __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }
		// @property (nonatomic, strong) UIColor * _Nullable titleColor __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }
		// @property (nonatomic, strong) UIFont * _Nullable bodyFont __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("bodyFont", ArgumentSemantic.Strong)]
		UIFont BodyFont { get; set; }
		// @property (nonatomic, strong) UIColor * _Nullable bodyColor __attribute__((annotate("ui_appearance_selector")));
		[NullAllowed, Export ("bodyColor", ArgumentSemantic.Strong)]
		UIColor BodyColor { get; set; }
		// @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
		[Export ("mdc_adjustsFontForContentSizeCategory")]
		bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }
	}
}
