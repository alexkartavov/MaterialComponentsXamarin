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
	// @interface MDCButtonTypographyThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCButtonTypographyThemer
	{
		// +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toButton:(MDCButton * _Nonnull)button;
		[Static]
		[Export ("applyTypographyScheme:toButton:")]
		void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCButton button);
	}
}
