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
	// typedef void (^MDCActionHandler)(MDCAlertAction * _Nonnull);
	delegate void MDCActionHandler (MDCAlertAction arg0);
	// @interface MDCAlertAction : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MDCAlertAction : INSCopying
	{
		// +(instancetype _Nonnull)actionWithTitle:(NSString * _Nonnull)title handler:(MDCActionHandler _Nullable)handler;
		[Static]
		[Export ("actionWithTitle:handler:")]
		MDCAlertAction ActionWithTitle (string title, [NullAllowed] MDCActionHandler handler);
		// @property (readonly, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }
	}
}
