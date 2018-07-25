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
	// @interface MDCSemanticColorScheme : NSObject <MDCColorScheming>
	[BaseType (typeof(NSObject))]
	interface MDCSemanticColorScheme : MDCColorScheming
	{
		// @property (readwrite, nonatomic) UIColor * _Nonnull primaryColor;
		[Export ("primaryColor", ArgumentSemantic.Assign)]
        new UIColor PrimaryColor { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull primaryColorVariant;
		[Export ("primaryColorVariant", ArgumentSemantic.Assign)]
        new UIColor PrimaryColorVariant { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull secondaryColor;
		[Export ("secondaryColor", ArgumentSemantic.Assign)]
        new UIColor SecondaryColor { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull errorColor;
		[Export ("errorColor", ArgumentSemantic.Assign)]
        new UIColor ErrorColor { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull surfaceColor;
		[Export ("surfaceColor", ArgumentSemantic.Assign)]
        new UIColor SurfaceColor { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Assign)]
        new UIColor BackgroundColor { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull onPrimaryColor;
		[Export ("onPrimaryColor", ArgumentSemantic.Assign)]
        new UIColor OnPrimaryColor { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull onSecondaryColor;
		[Export ("onSecondaryColor", ArgumentSemantic.Assign)]
        new UIColor OnSecondaryColor { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull onSurfaceColor;
		[Export ("onSurfaceColor", ArgumentSemantic.Assign)]
        new UIColor OnSurfaceColor { get; set; }
		// @property (readwrite, nonatomic) UIColor * _Nonnull onBackgroundColor;
		[Export ("onBackgroundColor", ArgumentSemantic.Assign)]
        new UIColor OnBackgroundColor { get; set; }
		// -(instancetype _Nonnull)initWithDefaults:(MDCColorSchemeDefaults)defaults;
		[Export ("initWithDefaults:")]
		IntPtr Constructor (MDCColorSchemeDefaults defaults);
		// +(UIColor * _Nonnull)blendColor:(UIColor * _Nonnull)color withBackgroundColor:(UIColor * _Nonnull)backgroundColor;
		[Static]
		[Export ("blendColor:withBackgroundColor:")]
		UIColor BlendColor (UIColor color, UIColor backgroundColor);
	}
}
