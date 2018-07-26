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
	// @interface MDCTextButtonThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCTextButtonThemer
	{
		// +(void)applyScheme:(id<MDCButtonScheming> _Nonnull)scheme toButton:(MDCButton * _Nonnull)button;
		[Static]
		[Export ("applyScheme:toButton:")]
		void ApplyScheme (MDCButtonScheming scheme, MDCButton button);
	}
}
