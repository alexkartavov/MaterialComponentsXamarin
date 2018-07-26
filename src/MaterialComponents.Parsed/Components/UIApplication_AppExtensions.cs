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
	// @interface AppExtensions (UIApplication)
	[Category]
	[BaseType (typeof(UIApplication))]
	interface UIApplication_AppExtensions
	{
		// +(UIApplication *)mdc_safeSharedApplication;
		[Static]
		[Export ("mdc_safeSharedApplication")]
		//[Verify (MethodToProperty)]
        UIApplication Mdc_safeSharedApplication();
		// +(BOOL)mdc_isAppExtension;
		[Static]
		[Export ("mdc_isAppExtension")]
		//[Verify (MethodToProperty)]
        bool Mdc_isAppExtension();
	}
}
