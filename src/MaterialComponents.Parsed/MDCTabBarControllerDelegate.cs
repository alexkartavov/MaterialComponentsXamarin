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
	// @protocol MDCTabBarControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCTabBarControllerDelegate
	{
		// @optional -(BOOL)tabBarController:(MDCTabBarViewController * _Nonnull)tabBarController shouldSelectViewController:(UIViewController * _Nonnull)viewController;
		[Export ("tabBarController:shouldSelectViewController:")]
		bool TabBarController (MDCTabBarViewController tabBarController, UIViewController viewController);
		// @optional -(void)tabBarController:(MDCTabBarViewController * _Nonnull)tabBarController didSelectViewController:(UIViewController * _Nonnull)viewController;
		[Export ("tabBarController:didSelectViewController:")]
		void TabBarController (MDCTabBarViewController tabBarController, UIViewController viewController);
	}
}
