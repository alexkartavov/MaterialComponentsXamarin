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
	// @interface MDCEdgeTreatment : NSObject <NSCopying, NSSecureCoding>
	[BaseType (typeof(NSObject))]
	interface MDCEdgeTreatment : INSCopying, INSSecureCoding
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
		// -(MDCPathGenerator * _Nonnull)pathGeneratorForEdgeWithLength:(CGFloat)length;
		[Export ("pathGeneratorForEdgeWithLength:")]
		MDCPathGenerator PathGeneratorForEdgeWithLength (nfloat length);
	}
}
