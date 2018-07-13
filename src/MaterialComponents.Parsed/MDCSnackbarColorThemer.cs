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
	// @interface MDCSnackbarColorThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCSnackbarColorThemer
	{
		// +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme;
		[Static]
		[Export ("applySemanticColorScheme:")]
		void ApplySemanticColorScheme (MDCColorScheming colorScheme);
		// +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toSnackbarMessageView:(MDCSnackbarMessageView * _Nonnull)snackbarMessageView __attribute__((deprecated("use applySemanticColorScheme: instead.")));
		[Static]
		[Export ("applyColorScheme:toSnackbarMessageView:")]
		void ApplyColorScheme (MDCColorScheme colorScheme, MDCSnackbarMessageView snackbarMessageView);
	}
}
