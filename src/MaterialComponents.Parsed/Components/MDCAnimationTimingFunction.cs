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
	[Native]
	public enum MDCAnimationTimingFunction : ulong
	{
		Standard,
		Deceleration,
		Acceleration,
		Sharp,
		EaseInOut = Standard,
		EaseOut = Deceleration,
		EaseIn = Acceleration,
		Translate = Standard,
		TranslateOnScreen = Deceleration,
		TranslateOffScreen = Acceleration,
		FadeIn = Deceleration,
		FadeOut = Acceleration
	}
}
