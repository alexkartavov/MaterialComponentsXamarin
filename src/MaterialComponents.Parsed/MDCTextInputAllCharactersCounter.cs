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
	// @interface MDCTextInputAllCharactersCounter : NSObject <MDCTextInputCharacterCounter>
	[BaseType (typeof(NSObject))]
	interface MDCTextInputAllCharactersCounter : IMDCTextInputCharacterCounter
	{
	}
}
