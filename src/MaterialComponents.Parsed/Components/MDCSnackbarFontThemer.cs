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
	// @interface MDCSnackbarFontThemer : NSObject
	[BaseType (typeof(NSObject))]
	interface MDCSnackbarFontThemer
	{
		// +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toSnackbarMessageView:(MDCSnackbarMessageView * _Nonnull)snackbarMessageView;
		[Static]
		[Export ("applyFontScheme:toSnackbarMessageView:")]
		void ApplyFontScheme (MDCFontScheme fontScheme, MDCSnackbarMessageView snackbarMessageView);
		// +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme;
		[Static]
		[Export ("applyFontScheme:")]
		void ApplyFontScheme (MDCFontScheme fontScheme);
	}
}
