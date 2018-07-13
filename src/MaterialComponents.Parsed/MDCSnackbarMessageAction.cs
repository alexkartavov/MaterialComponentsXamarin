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
	// @interface MDCSnackbarMessageAction : NSObject <UIAccessibilityIdentification, NSCopying>
	[BaseType (typeof(NSObject))]
	interface MDCSnackbarMessageAction : IUIAccessibilityIdentification, INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }
		// @property (copy, nonatomic) MDCSnackbarMessageActionHandler _Nullable handler;
		[NullAllowed, Export ("handler", ArgumentSemantic.Copy)]
		MDCSnackbarMessageActionHandler Handler { get; set; }
	}
}
