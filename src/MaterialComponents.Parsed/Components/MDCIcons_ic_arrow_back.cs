﻿using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using MaterialComponents;
using ObjCRuntime;
using UIKit;
using System.Runtime.InteropServices;

namespace MaterialComponents
{
	// @interface ic_arrow_back (MDCIcons)
	[Category]
	[BaseType (typeof(MDCIcons))]
	interface MDCIcons_ic_arrow_back
	{
		// +(NSString * _Nonnull)pathFor_ic_arrow_back;
		[Static]
		[Export ("pathFor_ic_arrow_back")]
		//[Verify (MethodToProperty)]
        string PathFor_ic_arrow_back();
		// +(void)ic_arrow_backUseNewStyle:(BOOL)useNewStyle;
		[Static]
		[Export ("ic_arrow_backUseNewStyle:")]
		void Ic_arrow_backUseNewStyle (bool useNewStyle);
		// +(UIImage * _Nullable)imageFor_ic_arrow_back;
		[Static]
		[NullAllowed, Export ("imageFor_ic_arrow_back")]
		//[Verify (MethodToProperty)]
        UIImage ImageFor_ic_arrow_back();
	}
}
