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
	// @interface MDCBottomNavigationBarTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCBottomNavigationBarTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toBottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar;
		[Static]
		[Export ("applyTypographyScheme:toBottomNavigationBar:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCBottomNavigationBar bottomNavigationBar);
	}
}
