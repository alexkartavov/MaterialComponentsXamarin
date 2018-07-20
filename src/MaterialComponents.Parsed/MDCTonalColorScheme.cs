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
	// @interface MDCTonalColorScheme : NSObject <MDCColorScheme, NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MDCTonalColorScheme : MDCColorScheme, INSCopying
	{
		// @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryColor;
		[Export ("primaryColor", ArgumentSemantic.Strong)]
        new UIColor PrimaryColor { get; }
		// @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryLightColor;
		[Export ("primaryLightColor", ArgumentSemantic.Strong)]
        new UIColor PrimaryLightColor { get; }
		// @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryDarkColor;
		[Export ("primaryDarkColor", ArgumentSemantic.Strong)]
        new UIColor PrimaryDarkColor { get; }
		// @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryColor;
		[Export ("secondaryColor", ArgumentSemantic.Strong)]
        new UIColor SecondaryColor { get; }
		// @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryLightColor;
		[Export ("secondaryLightColor", ArgumentSemantic.Strong)]
        new UIColor SecondaryLightColor { get; }
		// @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryDarkColor;
		[Export ("secondaryDarkColor", ArgumentSemantic.Strong)]
        new UIColor SecondaryDarkColor { get; }
		// @property (readonly, nonatomic, strong) MDCTonalPalette * _Nonnull primaryTonalPalette;
		[Export ("primaryTonalPalette", ArgumentSemantic.Strong)]
		MDCTonalPalette PrimaryTonalPalette { get; }
		// @property (readonly, nonatomic, strong) MDCTonalPalette * _Nonnull secondaryTonalPalette;
		[Export ("secondaryTonalPalette", ArgumentSemantic.Strong)]
		MDCTonalPalette SecondaryTonalPalette { get; }
		// -(instancetype _Nonnull)initWithPrimaryTonalPalette:(MDCTonalPalette * _Nonnull)primaryTonalPalette secondaryTonalPalette:(MDCTonalPalette * _Nonnull)secondaryTonalPalette __attribute__((objc_designated_initializer));
		[Export ("initWithPrimaryTonalPalette:secondaryTonalPalette:")]
		[DesignatedInitializer]
		IntPtr Constructor (MDCTonalPalette primaryTonalPalette, MDCTonalPalette secondaryTonalPalette);
	}
}
