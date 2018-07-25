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
	// @interface Animation (MDCFloatingButton)
	[Category]
	[BaseType (typeof(MDCFloatingButton))]
	interface MDCFloatingButton_Animation
	{
		// -(void)expand:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
		[Export ("expand:completion:")]
		void Expand (bool animated, [NullAllowed] Action completion);
		// -(void)collapse:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
		[Export ("collapse:completion:")]
		void Collapse (bool animated, [NullAllowed] Action completion);
	}
}
