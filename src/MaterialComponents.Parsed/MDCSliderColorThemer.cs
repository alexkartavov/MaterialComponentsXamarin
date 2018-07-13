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
	// @interface MDCSliderColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCSliderColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toSlider:(MDCSlider * _Nonnull)slider;
		[Static]
		[Export ("applySemanticColorScheme:toSlider:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCSlider slider);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toSlider:(MDCSlider * _Nonnull)slider;
		[Static]
		[Export ("applyColorScheme:toSlider:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCSlider slider);
		// +(MDCBasicColorScheme * _Nonnull)defaultSliderLightColorScheme;
		[Static]
		[Export ("defaultSliderLightColorScheme")]
		[Verify (MethodToProperty)]
		MDCBasicColorScheme DefaultSliderLightColorScheme { get; }
		// +(MDCBasicColorScheme * _Nonnull)defaultSliderDarkColorScheme;
		[Static]
		[Export ("defaultSliderDarkColorScheme")]
		[Verify (MethodToProperty)]
		MDCBasicColorScheme DefaultSliderDarkColorScheme { get; }
	}
}
