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
	// @protocol MDCButtonScheming
	[Protocol, Model]
	interface MDCButtonScheming
	{
		// @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
		[Abstract]
		[Export ("colorScheme")]
		MDCColorScheming ColorScheme { get; }
		// @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
		[Abstract]
		[Export ("typographyScheme")]
		MDCTypographyScheming TypographyScheme { get; }
		// @required @property (readonly, nonatomic) CGFloat cornerRadius;
		[Abstract]
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; }
		// @required @property (readonly, nonatomic) CGFloat minimumHeight;
		[Abstract]
		[Export ("minimumHeight")]
		nfloat MinimumHeight { get; }
	}
}
