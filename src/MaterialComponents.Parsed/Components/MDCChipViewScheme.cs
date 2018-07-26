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
	// @interface MDCChipViewScheme : NSObject <MDCChipViewScheming>
	[BaseType (typeof(NSObject))]
	interface MDCChipViewScheme : MDCChipViewScheming
	{
		// @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
		[Export ("colorScheme", ArgumentSemantic.Assign)]
		MDCColorScheming ColorScheme { get; set; }
		// @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
		[Export ("typographyScheme", ArgumentSemantic.Assign)]
		MDCTypographyScheming TypographyScheme { get; set; }
	}
}
