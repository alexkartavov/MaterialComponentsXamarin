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
	// @interface BundleLoader (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_BundleLoader
	{
		// +(NSString * _Nonnull)pathForIconName:(NSString * _Nonnull)iconName withBundleName:(NSString * _Nonnull)bundleName;
		[Static]
		[Export ("pathForIconName:withBundleName:")]
		string PathForIconName (string iconName, string bundleName);
		// +(NSBundle * _Nullable)bundleNamed:(NSString * _Nonnull)bundleName;
		[Static]
		[Export ("bundleNamed:")]
		[return: NullAllowed]
		NSBundle BundleNamed (string bundleName);
	}
}
