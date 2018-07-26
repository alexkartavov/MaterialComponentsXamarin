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
	// @protocol MDCTabBarIndicatorContext <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCTabBarIndicatorContext
	{
		// @required @property (readonly, nonatomic) UITabBarItem * _Nonnull item;
		[Abstract]
		[Export ("item")]
		UITabBarItem Item { get; }
		// @required @property (readonly, nonatomic) CGRect bounds;
		[Abstract]
		[Export ("bounds")]
		CGRect Bounds { get; }
		// @required @property (readonly, nonatomic) CGRect contentFrame;
		[Abstract]
		[Export ("contentFrame")]
		CGRect ContentFrame { get; }
	}
}
