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
	// @protocol MDCChipViewScheming
	[Protocol, Model]
	interface MDCChipViewScheming
	{
		// @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
		[Abstract]
		[Export ("colorScheme")]
		MDCColorScheming ColorScheme { get; }
		// @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
		[Abstract]
		[Export ("typographyScheme")]
		MDCTypographyScheming TypographyScheme { get; }
	}
}
