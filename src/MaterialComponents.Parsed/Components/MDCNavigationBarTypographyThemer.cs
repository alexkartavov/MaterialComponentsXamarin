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
	// @interface MDCNavigationBarTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCNavigationBarTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
		[Static]
		[Export ("applyTypographyScheme:toNavigationBar:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCNavigationBar navigationBar);
	}
}
