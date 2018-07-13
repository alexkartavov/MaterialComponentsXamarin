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
	// @interface MDCHeaderStackView : UIView
	[BaseType (typeof(UIView))]
	interface MDCHeaderStackView
	{
		// @property (nonatomic, strong) UIView * _Nullable topBar;
		[NullAllowed, Export ("topBar", ArgumentSemantic.Strong)]
		UIView TopBar { get; set; }
		// @property (nonatomic, strong) UIView * _Nullable bottomBar;
		[NullAllowed, Export ("bottomBar", ArgumentSemantic.Strong)]
		UIView BottomBar { get; set; }
	}
}
