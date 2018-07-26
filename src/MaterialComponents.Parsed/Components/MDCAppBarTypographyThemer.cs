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
	// @interface MDCAppBarTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCAppBarTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
		[Static]
		[Export ("applyTypographyScheme:toAppBar:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCAppBar appBar);
	}
}
