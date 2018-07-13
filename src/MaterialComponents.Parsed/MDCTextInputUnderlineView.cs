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
	// @interface MDCTextInputUnderlineView : UIView <NSCopying, NSSecureCoding>
	[BaseType (typeof(UIView))]
	interface MDCTextInputUnderlineView : INSCopying, INSSecureCoding
	{
		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }
		// @property (nonatomic, strong) UIColor * disabledColor;
		[Export ("disabledColor", ArgumentSemantic.Strong)]
		UIColor DisabledColor { get; set; }
		// @property (assign, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { get; set; }
		// @property (assign, nonatomic) CGFloat lineHeight;
		[Export ("lineHeight")]
		nfloat LineHeight { get; set; }
	}
}
