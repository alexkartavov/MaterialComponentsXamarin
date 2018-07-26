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
	// @protocol MDCChipFieldDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MDCChipFieldDelegate
	{
		// @optional -(void)chipFieldDidBeginEditing:(MDCChipField * _Nonnull)chipField;
		[Export ("chipFieldDidBeginEditing:")]
		void ChipFieldDidBeginEditing (MDCChipField chipField);
		// @optional -(void)chipFieldDidEndEditing:(MDCChipField * _Nonnull)chipField;
		[Export ("chipFieldDidEndEditing:")]
		void ChipFieldDidEndEditing (MDCChipField chipField);
		// @optional -(void)chipField:(MDCChipField * _Nonnull)chipField didAddChip:(MDCChipView * _Nonnull)chip;
		[Export ("chipField:didAddChip:")]
		void ChipField (MDCChipField chipField, MDCChipView chip);
		// @optional -(BOOL)chipField:(MDCChipField * _Nonnull)chipField shouldAddChip:(MDCChipView * _Nonnull)chip;
		[Export ("chipField:shouldAddChip:")]
        bool ChipField_shouldAddChip (MDCChipField chipField, MDCChipView chip);
		// @optional -(void)chipField:(MDCChipField * _Nonnull)chipField didRemoveChip:(MDCChipView * _Nonnull)chip;
		[Export ("chipField:didRemoveChip:")]
        void ChipField_didRemoveChip (MDCChipField chipField, MDCChipView chip);
		// @optional -(void)chipFieldHeightDidChange:(MDCChipField * _Nonnull)chipField;
		[Export ("chipFieldHeightDidChange:")]
		void ChipFieldHeightDidChange (MDCChipField chipField);
		// @optional -(void)chipField:(MDCChipField * _Nonnull)chipField didChangeInput:(NSString * _Nullable)input;
		[Export ("chipField:didChangeInput:")]
        void ChipField_shouldAddChip (MDCChipField chipField, [NullAllowed] string input);
		// @optional -(void)chipField:(MDCChipField * _Nonnull)chipField didTapChip:(MDCChipView * _Nonnull)chip;
		[Export ("chipField:didTapChip:")]
        void ChipField_didTapChip (MDCChipField chipField, MDCChipView chip);
		// @optional -(BOOL)chipFieldShouldReturn:(MDCChipField * _Nonnull)chipField;
		[Export ("chipFieldShouldReturn:")]
		bool ChipFieldShouldReturn (MDCChipField chipField);
		// @optional -(BOOL)chipFieldShouldBecomeFirstResponder:(MDCChipField * _Nonnull)chipField;
		[Export ("chipFieldShouldBecomeFirstResponder:")]
		bool ChipFieldShouldBecomeFirstResponder (MDCChipField chipField);
	}
}
