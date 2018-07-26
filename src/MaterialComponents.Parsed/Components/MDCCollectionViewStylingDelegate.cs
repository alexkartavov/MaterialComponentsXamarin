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
	// @protocol MDCCollectionViewStylingDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCCollectionViewStylingDelegate
	{
		// @optional -(CGFloat)collectionView:(UICollectionView * _Nonnull)collectionView cellHeightAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:cellHeightAtIndexPath:")]
		nfloat CollectionView (UICollectionView collectionView, NSIndexPath indexPath);
		// @optional -(MDCCollectionViewCellStyle)collectionView:(UICollectionView * _Nonnull)collectionView cellStyleForSection:(NSInteger)section;
		[Export ("collectionView:cellStyleForSection:")]
		MDCCollectionViewCellStyle CollectionView (UICollectionView collectionView, nint section);
		// @optional -(UIColor * _Nullable)collectionView:(UICollectionView * _Nonnull)collectionView cellBackgroundColorAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:cellBackgroundColorAtIndexPath:")]
		[return: NullAllowed]
        UIColor CollectionView_cellBackgroundColorAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);
		// @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideItemBackgroundAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:shouldHideItemBackgroundAtIndexPath:")]
        bool CollectionView_shouldHideItemBackgroundAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);
		// @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideHeaderBackgroundForSection:(NSInteger)section;
		[Export ("collectionView:shouldHideHeaderBackgroundForSection:")]
        bool CollectionView_shouldHideHeaderBackgroundForSection (UICollectionView collectionView, nint section);
		// @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideFooterBackgroundForSection:(NSInteger)section;
		[Export ("collectionView:shouldHideFooterBackgroundForSection:")]
        bool CollectionView_shouldHideFooterBackgroundForSection (UICollectionView collectionView, nint section);
		// @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideItemSeparatorAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:shouldHideItemSeparatorAtIndexPath:")]
        bool CollectionView_shouldHideItemSeparatorAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);
		// @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideHeaderSeparatorForSection:(NSInteger)section;
		[Export ("collectionView:shouldHideHeaderSeparatorForSection:")]
        bool CollectionView_shouldHideHeaderSeparatorForSection (UICollectionView collectionView, nint section);
		// @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideFooterSeparatorForSection:(NSInteger)section;
		[Export ("collectionView:shouldHideFooterSeparatorForSection:")]
        bool CollectionView_shouldHideFooterSeparatorForSection (UICollectionView collectionView, nint section);
		// @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didApplyInlayToItemAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
		[Export ("collectionView:didApplyInlayToItemAtIndexPaths:")]
		void CollectionView (UICollectionView collectionView, NSIndexPath[] indexPaths);
		// @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didRemoveInlayFromItemAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
		[Export ("collectionView:didRemoveInlayFromItemAtIndexPaths:")]
        void CollectionView_didRemoveInlayFromItemAtIndexPaths (UICollectionView collectionView, NSIndexPath[] indexPaths);
		// @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView hidesInkViewAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:hidesInkViewAtIndexPath:")]
        bool CollectionView_hidesInkViewAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);
		// @optional -(UIColor * _Nullable)collectionView:(UICollectionView * _Nonnull)collectionView inkColorAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:inkColorAtIndexPath:")]
		[return: NullAllowed]
        UIColor CollectionView_inkColorAtIndexPath (UICollectionView collectionView, NSIndexPath indexPath);
		// @optional -(MDCInkView * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController inkViewAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:inkTouchController:inkViewAtIndexPath:")]
		MDCInkView CollectionView (UICollectionView collectionView, MDCInkTouchController inkTouchController, NSIndexPath indexPath);
	}
}
