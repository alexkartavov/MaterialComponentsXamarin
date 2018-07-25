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
	// @protocol MDCShapeGenerating <NSCopying, NSSecureCoding>
	[Protocol, Model]
	interface MDCShapeGenerating : INSCopying, INSSecureCoding
	{
		// @required -(CGPathRef _Nullable)pathForSize:(CGSize)size;
		[Abstract]
		[Export ("pathForSize:")]
		[return: NullAllowed]
		unsafe CGPathRef* PathForSize (CGSize size);
	}
}
