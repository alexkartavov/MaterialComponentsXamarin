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
		// extern const CGFloat MDCCellDefaultOneLineHeight;
		[Field ("MDCCellDefaultOneLineHeight", "__Internal")]
		nfloat MDCCellDefaultOneLineHeight { get; }
		// extern const CGFloat MDCCellDefaultOneLineWithAvatarHeight;
		[Field ("MDCCellDefaultOneLineWithAvatarHeight", "__Internal")]
		nfloat MDCCellDefaultOneLineWithAvatarHeight { get; }
		// extern const CGFloat MDCCellDefaultTwoLineHeight;
		[Field ("MDCCellDefaultTwoLineHeight", "__Internal")]
		nfloat MDCCellDefaultTwoLineHeight { get; }
		// extern const CGFloat MDCCellDefaultThreeLineHeight;
		[Field ("MDCCellDefaultThreeLineHeight", "__Internal")]
		nfloat MDCCellDefaultThreeLineHeight { get; }
	}
	// @interface MDCCollectionViewTextCell : MDCCollectionViewCell
	[BaseType (typeof(MDCCollectionViewCell))]
	interface MDCCollectionViewTextCell
	{
		// @property (readonly, nonatomic, strong) UILabel * _Nullable textLabel;
		[NullAllowed, Export ("textLabel", ArgumentSemantic.Strong)]
		UILabel TextLabel { get; }
		// @property (readonly, nonatomic, strong) UILabel * _Nullable detailTextLabel;
		[NullAllowed, Export ("detailTextLabel", ArgumentSemantic.Strong)]
		UILabel DetailTextLabel { get; }
		// @property (readonly, nonatomic, strong) UIImageView * _Nullable imageView;
		[NullAllowed, Export ("imageView", ArgumentSemantic.Strong)]
		UIImageView ImageView { get; }
	}
}
