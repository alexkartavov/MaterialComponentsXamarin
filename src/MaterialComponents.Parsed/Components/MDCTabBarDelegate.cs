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
	// @protocol MDCTabBarDelegate <UIBarPositioningDelegate>
	[Protocol, Model]
	interface MDCTabBarDelegate : IUIBarPositioningDelegate
	{
		// @optional -(BOOL)tabBar:(MDCTabBar * _Nonnull)tabBar shouldSelectItem:(UITabBarItem * _Nonnull)item;
		[Export ("tabBar:shouldSelectItem:")]
		bool TabBar (MDCTabBar tabBar, UITabBarItem item);
		// @optional -(void)tabBar:(MDCTabBar * _Nonnull)tabBar willSelectItem:(UITabBarItem * _Nonnull)item;
		[Export ("tabBar:willSelectItem:")]
        void TabBar_willSelectItem (MDCTabBar tabBar, UITabBarItem item);
		// @optional -(void)tabBar:(MDCTabBar * _Nonnull)tabBar didSelectItem:(UITabBarItem * _Nonnull)item;
		[Export ("tabBar:didSelectItem:")]
        void TabBar_didSelectItem (MDCTabBar tabBar, UITabBarItem item);
	}
}
