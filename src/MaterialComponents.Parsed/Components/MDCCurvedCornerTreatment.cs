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
	// @interface MDCCurvedCornerTreatment : MDCCornerTreatment
	[BaseType (typeof(MDCCornerTreatment))]
	interface MDCCurvedCornerTreatment
	{
		// @property (assign, nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }
		// -(instancetype _Nonnull)initWithSize:(CGSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithSize:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGSize size);
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}
}
