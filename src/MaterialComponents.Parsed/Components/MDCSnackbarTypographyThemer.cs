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
	// @interface MDCSnackbarTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCSnackbarTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme;
		[Static]
		[Export ("applyTypographyScheme:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme);
	}
}
