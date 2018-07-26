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
	// @interface MDCAlertTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCAlertTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAlertController:(MDCAlertController * _Nonnull)alertController;
		[Static]
		[Export ("applyTypographyScheme:toAlertController:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCAlertController alertController);
	}
}
