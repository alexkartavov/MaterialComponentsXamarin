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
	// @interface MDCSystemFontLoader : NSObject <MDCTypographyFontLoading>
	[BaseType (typeof(NSObject))]
	interface MDCSystemFontLoader : MDCTypographyFontLoading
	{
	}
}
