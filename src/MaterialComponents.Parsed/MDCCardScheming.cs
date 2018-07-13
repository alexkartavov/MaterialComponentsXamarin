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
	// @protocol MDCCardScheming
	[Protocol, Model]
	interface MDCCardScheming
	{
		// @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
		[Abstract]
		[Export ("colorScheme")]
		MDCColorScheming ColorScheme { get; }
	}
}
