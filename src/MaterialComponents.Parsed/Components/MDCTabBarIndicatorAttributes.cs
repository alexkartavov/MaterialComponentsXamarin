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
	// @interface MDCTabBarIndicatorAttributes : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface MDCTabBarIndicatorAttributes : INSCopying
	{
		// @property (nonatomic) UIBezierPath * _Nullable path;
		[NullAllowed, Export ("path", ArgumentSemantic.Assign)]
		UIBezierPath Path { get; set; }
	}
}
