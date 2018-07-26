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
	// @protocol MDCOverlay <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCOverlay
	{
		// @required @property (readonly, copy, nonatomic) NSString * identifier;
		[Abstract]
		[Export ("identifier")]
		string Identifier { get; }
		// @required @property (readonly, nonatomic) CGRect frame;
		[Abstract]
		[Export ("frame")]
		CGRect Frame { get; }
	}
}
