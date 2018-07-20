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
	// @interface MDCBasicColorScheme : NSObject <MDCColorScheme, NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MDCBasicColorScheme : MDCColorScheme, INSCopying
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
		// -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor primaryLightColor:(UIColor * _Nonnull)primaryLightColor primaryDarkColor:(UIColor * _Nonnull)primaryDarkColor secondaryColor:(UIColor * _Nonnull)secondaryColor secondaryLightColor:(UIColor * _Nonnull)secondaryLightColor secondaryDarkColor:(UIColor * _Nonnull)secondaryDarkColor __attribute__((objc_designated_initializer));
		[Export ("initWithPrimaryColor:primaryLightColor:primaryDarkColor:secondaryColor:secondaryLightColor:secondaryDarkColor:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIColor primaryColor, UIColor primaryLightColor, UIColor primaryDarkColor, UIColor secondaryColor, UIColor secondaryLightColor, UIColor secondaryDarkColor);
		// -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor;
		[Export ("initWithPrimaryColor:")]
		IntPtr Constructor (UIColor primaryColor);
		// -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor primaryLightColor:(UIColor * _Nonnull)primaryLightColor primaryDarkColor:(UIColor * _Nonnull)primaryDarkColor;
		[Export ("initWithPrimaryColor:primaryLightColor:primaryDarkColor:")]
		IntPtr Constructor (UIColor primaryColor, UIColor primaryLightColor, UIColor primaryDarkColor);
		// -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor;
		[Export ("initWithPrimaryColor:secondaryColor:")]
		IntPtr Constructor (UIColor primaryColor, UIColor secondaryColor);
	}
}
