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
	// @interface MDCCardScheme : NSObject <MDCCardScheming>
	[BaseType (typeof(NSObject))]
	interface MDCCardScheme : MDCCardScheming
	{
		// @property (readwrite, nonatomic) MDCSemanticColorScheme * _Nonnull colorScheme;
		[Export ("colorScheme", ArgumentSemantic.Assign)]
		MDCSemanticColorScheme ColorScheme { get; set; }
	}
}
