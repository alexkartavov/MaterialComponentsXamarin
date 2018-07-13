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
	// @interface MDCTextInputControllerFullWidth : NSObject <MDCTextInputController>
	[BaseType (typeof(NSObject))]
	interface MDCTextInputControllerFullWidth : IMDCTextInputController
	{
	}
}
