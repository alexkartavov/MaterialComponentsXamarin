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
}
