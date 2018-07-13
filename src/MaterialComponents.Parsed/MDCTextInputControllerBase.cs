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
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CGFloat MDCTextInputControllerBaseDefaultBorderRadius;
		[Field ("MDCTextInputControllerBaseDefaultBorderRadius", "__Internal")]
		nfloat MDCTextInputControllerBaseDefaultBorderRadius { get; }
	}
	// @interface MDCTextInputControllerBase : NSObject <MDCTextInputControllerFloatingPlaceholder>
	[BaseType (typeof(NSObject))]
	interface MDCTextInputControllerBase : IMDCTextInputControllerFloatingPlaceholder
	{
		// @property (nonatomic, strong) UIColor * _Null_unspecified backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }
		// @property (nonatomic, strong) UIColor * _Nullable borderFillColor;
		[NullAllowed, Export ("borderFillColor", ArgumentSemantic.Strong)]
		UIColor BorderFillColor { get; set; }
		// @property (nonatomic, strong, class) UIColor * _Null_unspecified borderFillColorDefault;
		[Static]
		[Export ("borderFillColorDefault", ArgumentSemantic.Strong)]
		UIColor BorderFillColorDefault { get; set; }
		// @property (assign, nonatomic) BOOL expandsOnOverflow;
		[Export ("expandsOnOverflow")]
		bool ExpandsOnOverflow { get; set; }
		// @property (assign, nonatomic) NSUInteger minimumLines;
		[Export ("minimumLines")]
		nuint MinimumLines { get; set; }
	}
}
