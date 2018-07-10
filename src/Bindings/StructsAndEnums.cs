using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using ObjCRuntime;

[Native]
public enum MDCActivityIndicatorMode : nint
{
	Indeterminate,
	Determinate
}

[Native]
public enum MDCColorSchemeDefaults : nint
{
	MDCColorSchemeDefaultsMaterial201804
}

[Native]
public enum MDCAnimationTimingFunction : nuint
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

[Native]
public enum MDCFlexibleHeaderShiftBehavior : nint
{
	Disabled,
	Enabled,
	EnabledWithStatusBar
}

[Native]
public enum MDCFlexibleHeaderContentImportance : nint
{
	Default,
	High
}

[Native]
public enum MDCFlexibleHeaderScrollPhase : nint
{
	Shifting,
	Collapsing,
	OverExtending
}

[Native]
public enum MDCNavigationBarTitleAlignment : nint
{
	Center,
	Leading
}

[Native]
public enum MDCTypographySchemeDefaults : nint
{
	MDCTypographySchemeDefaultsMaterial201804
}

[Native]
public enum MDCInkStyle : nint
{
	Bounded,
	Unbounded
}

[Native]
public enum MDCFloatingButtonShape : nint
{
	Default = 0,
	Mini = 1
}

[Native]
public enum MDCFloatingButtonMode : nint
{
	Normal = 0,
	Expanded = 1
}

[Native]
public enum MDCFloatingButtonImageLocation : nint
{
	Leading = 0,
	Trailing = 1
}

[Native]
public enum MDCBottomAppBarFloatingButtonElevation : nint
{
	Primary = 0,
	Secondary = 1
}

[Native]
public enum MDCBottomAppBarFloatingButtonPosition : nint
{
	Center = 0,
	Leading = 1,
	Trailing = 2
}

[Native]
public enum MDCBottomNavigationBarTitleVisibility : nint
{
	Selected = 0,
	Always = 1,
	Never = 2
}

[Native]
public enum MDCBottomNavigationBarAlignment : nint
{
	Justified = 0,
	JustifiedAdjacentTitles = 1,
	Centered = 2
}

[Native]
public enum MDCButtonBarLayoutPosition : nuint
{
	None = 0,
	Leading = 1 << 0,
	Left = Leading,
	Trailing = 1 << 1,
	Right = Trailing
}

[Native]
public enum MDCBarButtonItemLayoutHints : nuint
{
	None = 0,
	IsFirstButton = 1 << 0,
	IsLastButton = 1 << 1
}

[Native]
public enum MDCCardCellState : nint
{
	Normal = 0,
	Highlighted,
	Selected
}

[Native]
public enum MDCCardCellHorizontalImageAlignment : nint
{
	Right = 0,
	Center,
	Left
}

[Native]
public enum MDCCardCellVerticalImageAlignment : nint
{
	Top = 0,
	Center,
	Bottom
}

[Native]
public enum MDCTextInputTextInsetsMode : nuint
{
	Never = 0,
	IfContent,
	Always
}

[Native]
public enum MDCChipFieldDelimiter : nuint
{
	None = 0,
	Return = 1 << 0,
	Space = 1 << 1,
	DidEndEditing = 1 << 2,
	Default = (Return | DidEndEditing),
	All = 4294967295L
}

[Native]
public enum MDCCollectionViewCellAccessoryType : nuint
{
	None,
	DisclosureIndicator,
	Checkmark,
	DetailButton
}

[Native]
public enum MDCCollectionViewOrdinalPosition : nuint
{
	VerticalTop = 1 << 0,
	VerticalCenter = 1 << 1,
	VerticalBottom = 1 << 2,
	VerticalTopBottom = (VerticalTop | VerticalBottom),
	HorizontalLeft = 1 << 10,
	HorizontalCenter = 1 << 11,
	HorizontalRight = 1 << 12
}

[Native]
public enum MDCCollectionViewCellStyle : nuint
{
	Default,
	Grouped,
	Card
}

[Native]
public enum MDCCollectionViewCellLayoutType : nuint
{
	List,
	Grid,
	Custom
}

[Native]
public enum MDCProgressViewBackwardAnimationMode : nint
{
	Reset,
	Animate
}

[Native]
public enum MDCTabBarAlignment : nint
{
	Leading,
	Justified,
	Center,
	CenterSelected
}

[Native]
public enum MDCTabBarItemAppearance : nint
{
	Titles,
	Images,
	TitledImages
}

[Native]
public enum MDCTabBarTextTransform : nint
{
	Automatic = 0,
	None = 1,
	Uppercase = 2
}

[Native]
public enum MDCTabBarItemState : nint
{
	Normal,
	Selected
}

[Native]
public enum MDCFontTextStyle : nint
{
	Body1,
	Body2,
	Caption,
	Headline,
	Subheadline,
	Title,
	Display1,
	Display2,
	Display3,
	Display4,
	Button
}

static class CFunctions
{
	// CGFloat MDCSin (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCSin (nfloat value);

	// CGFloat MDCCos (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCCos (nfloat value);

	// CGFloat MDCAtan2 (CGFloat y, CGFloat x);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCAtan2 (nfloat y, nfloat x);

	// CGFloat MDCCeil (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCCeil (nfloat value);

	// CGFloat MDCFabs (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCFabs (nfloat value);

	// CGFloat MDCDegreesToRadians (CGFloat degrees);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCDegreesToRadians (nfloat degrees);

	// _Bool MDCCGFloatEqual (CGFloat a, CGFloat b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern bool MDCCGFloatEqual (nfloat a, nfloat b);

	// CGFloat MDCFloor (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCFloor (nfloat value);

	// CGFloat MDCHypot (CGFloat x, CGFloat y);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCHypot (nfloat x, nfloat y);

	// BOOL MDCCGFloatIsExactlyZero (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern bool MDCCGFloatIsExactlyZero (nfloat value);

	// CGFloat MDCPow (CGFloat value, CGFloat power);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCPow (nfloat value, nfloat power);

	// CGFloat MDCRint (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCRint (nfloat value);

	// CGFloat MDCRound (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCRound (nfloat value);

	// CGFloat MDCSqrt (CGFloat value);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCSqrt (nfloat value);

	// CGRect MDCRectAlignToScale (CGRect rect, CGFloat scale);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern CGRect MDCRectAlignToScale (CGRect rect, nfloat scale);

	// CGPoint MDCPointRoundWithScale (CGPoint point, CGFloat scale);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern CGPoint MDCPointRoundWithScale (CGPoint point, nfloat scale);

	// CGSize MDCSizeCeilWithScale (CGSize size, CGFloat scale);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern CGSize MDCSizeCeilWithScale (CGSize size, nfloat scale);

	// CGPoint MDCRoundCenterWithBoundsAndScale (CGPoint center, CGRect bounds, CGFloat scale);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern CGPoint MDCRoundCenterWithBoundsAndScale (CGPoint center, CGRect bounds, nfloat scale);

	// extern CGFloat MDCDeviceTopSafeAreaInset ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MDCDeviceTopSafeAreaInset ();
}

[Native]
public enum MDCTriangleEdgeStyle : nuint
{
	Handle,
	Cut
}
