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
	// @protocol MDCTabBarIndicatorTemplate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCTabBarIndicatorTemplate
	{
		// @required -(MDCTabBarIndicatorAttributes * _Nonnull)indicatorAttributesForContext:(id<MDCTabBarIndicatorContext> _Nonnull)context;
		[Abstract]
		[Export ("indicatorAttributesForContext:")]
		MDCTabBarIndicatorAttributes IndicatorAttributesForContext (MDCTabBarIndicatorContext context);
	}
}
