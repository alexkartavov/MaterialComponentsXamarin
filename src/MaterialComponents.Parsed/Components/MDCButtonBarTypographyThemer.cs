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
	// @interface MDCButtonBarTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCButtonBarTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar;
		[Static]
		[Export ("applyTypographyScheme:toButtonBar:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCButtonBar buttonBar);
	}
}
