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
	// @interface MDCButtonScheme : NSObject <MDCButtonScheming>
	[BaseType (typeof(NSObject))]
	interface MDCButtonScheme : MDCButtonScheming
	{
		// @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
		[Export ("colorScheme", ArgumentSemantic.Assign)]
		MDCColorScheming ColorScheme { get; set; }
		// @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
		[Export ("typographyScheme", ArgumentSemantic.Assign)]
		MDCTypographyScheming TypographyScheme { get; set; }
		// @property (readwrite, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }
		// @property (readwrite, nonatomic) CGFloat minimumHeight;
		[Export ("minimumHeight")]
		nfloat MinimumHeight { get; set; }
	}
}
