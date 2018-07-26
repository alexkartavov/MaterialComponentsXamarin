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
	// @interface MDCAccessibility (MDCTabBar)
	[Category]
	[BaseType (typeof(MDCTabBar))]
	interface MDCTabBar_MDCAccessibility
	{
		// -(id _Nullable)accessibilityElementForItem:(UITabBarItem * _Nonnull)item;
		[Export ("accessibilityElementForItem:")]
		[return: NullAllowed]
		NSObject AccessibilityElementForItem (UITabBarItem item);
	}
}
