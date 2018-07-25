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
	// @interface MDCTextInputControllerLegacyFullWidth : MDCTextInputControllerFullWidth <NSSecureCoding>
	[BaseType (typeof(MDCTextInputControllerFullWidth))]
	interface MDCTextInputControllerLegacyFullWidth : INSSecureCoding
	{
	}
}
