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
	// @interface MDCFlatButton : MDCButton
	[BaseType (typeof(MDCButton))]
	interface MDCFlatButton
	{
		// @property (nonatomic) BOOL hasOpaqueBackground;
		[Export ("hasOpaqueBackground")]
		bool HasOpaqueBackground { get; set; }
	}
}
