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
	// @interface Subclassing (MDCShadowLayer) <CALayerDelegate>
	[Category]
	[BaseType (typeof(MDCShadowLayer))]
	interface MDCShadowLayer_Subclassing : ICALayerDelegate
	{
	}
}
