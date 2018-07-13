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
	// @interface MDCFloatingActionButtonThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCFloatingActionButtonThemer
	{
		// +(void)applyScheme:(id<MDCButtonScheming> _Nonnull)scheme toButton:(MDCFloatingButton * _Nonnull)button;
		[Static]
		[Export ("applyScheme:toButton:")]
		void ApplyScheme (MDCButtonScheming scheme, MDCFloatingButton button);
	}
}
