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
	// @interface MDCCurvedRectShapeGenerator : NSObject <MDCShapeGenerating>
	[BaseType (typeof(NSObject))]
	interface MDCCurvedRectShapeGenerator : IMDCShapeGenerating
	{
		// @property (assign, nonatomic) CGSize cornerSize;
		[Export ("cornerSize", ArgumentSemantic.Assign)]
		CGSize CornerSize { get; set; }
		// -(instancetype)initWithCornerSize:(CGSize)cornerSize __attribute__((objc_designated_initializer));
		[Export ("initWithCornerSize:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGSize cornerSize);
		// -(instancetype)initWithCoder:(NSCoder *)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}
}
