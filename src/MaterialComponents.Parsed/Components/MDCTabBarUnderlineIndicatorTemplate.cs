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
	// @interface MDCTabBarUnderlineIndicatorTemplate : NSObject <MDCTabBarIndicatorTemplate>
	[BaseType (typeof(NSObject))]
	interface MDCTabBarUnderlineIndicatorTemplate : MDCTabBarIndicatorTemplate
	{
	}
}
