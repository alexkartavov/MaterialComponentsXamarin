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
	// @interface MDCTypographyScheme : NSObject <MDCTypographyScheming>
	[BaseType (typeof(NSObject))]
	interface MDCTypographyScheme : MDCTypographyScheming
	{
		// @property (readwrite, nonatomic) UIFont * _Nonnull headline1;
		[Export ("headline1", ArgumentSemantic.Assign)]
        new UIFont Headline1 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull headline2;
		[Export ("headline2", ArgumentSemantic.Assign)]
        new UIFont Headline2 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull headline3;
		[Export ("headline3", ArgumentSemantic.Assign)]
        new UIFont Headline3 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull headline4;
		[Export ("headline4", ArgumentSemantic.Assign)]
        new UIFont Headline4 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull headline5;
		[Export ("headline5", ArgumentSemantic.Assign)]
        new UIFont Headline5 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull headline6;
		[Export ("headline6", ArgumentSemantic.Assign)]
        new UIFont Headline6 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull subtitle1;
		[Export ("subtitle1", ArgumentSemantic.Assign)]
        new UIFont Subtitle1 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull subtitle2;
		[Export ("subtitle2", ArgumentSemantic.Assign)]
        new UIFont Subtitle2 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull body1;
		[Export ("body1", ArgumentSemantic.Assign)]
        new UIFont Body1 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull body2;
		[Export ("body2", ArgumentSemantic.Assign)]
        new UIFont Body2 { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull caption;
		[Export ("caption", ArgumentSemantic.Assign)]
        new UIFont Caption { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull button;
		[Export ("button", ArgumentSemantic.Assign)]
        new UIFont Button { get; set; }
		// @property (readwrite, nonatomic) UIFont * _Nonnull overline;
		[Export ("overline", ArgumentSemantic.Assign)]
        new UIFont Overline { get; set; }
		// -(instancetype _Nonnull)initWithDefaults:(MDCTypographySchemeDefaults)defaults;
		[Export ("initWithDefaults:")]
		IntPtr Constructor (MDCTypographySchemeDefaults defaults);
	}
}
