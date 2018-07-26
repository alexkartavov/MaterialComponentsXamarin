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
	// @interface MDCHeaderStackViewColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCHeaderStackViewColorThemer
	{
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toHeaderStackView:(MDCHeaderStackView * _Nonnull)headerStackView;
		[Static]
		[Export ("applyColorScheme:toHeaderStackView:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCHeaderStackView headerStackView);
	}
}
