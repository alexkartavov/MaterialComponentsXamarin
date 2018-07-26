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
	// @protocol MDCSnackbarSuspensionToken <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCSnackbarSuspensionToken
	{
	}
}
