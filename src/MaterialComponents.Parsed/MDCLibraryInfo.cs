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
	// @interface MDCLibraryInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCLibraryInfo
	{
		// @property (readonly, nonatomic, class) NSString * _Nonnull versionString;
		[Static]
		[Export ("versionString")]
		string VersionString { get; }
	}
}
