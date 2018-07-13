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
	// @interface MDCPillShapeGenerator : NSObject <MDCShapeGenerating>
	[BaseType (typeof(NSObject))]
	interface MDCPillShapeGenerator : IMDCShapeGenerating
	{
	}
}
