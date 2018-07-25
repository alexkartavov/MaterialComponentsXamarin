using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCButton: View
    {
        public XfMDCButton()
        {
        }

        public static readonly BindableProperty InkColorProperty =
            BindableProperty.Create("InkColor", typeof(Color), typeof(XfMDCButton), null);

        public Color InkColor
        {
            get { return (Color)base.GetValue(InkColorProperty); }
            set { base.SetValue(InkColorProperty, value); }
        }

        public static readonly BindableProperty InkMaxRippleRadiusProperty =
            BindableProperty.Create("InkMaxRippleRadius", typeof(double), typeof(XfMDCButton), 0.0);

        public double InkMaxRippleRadius
        {
            get { return (double)base.GetValue(InkMaxRippleRadiusProperty); }
            set { base.SetValue(InkMaxRippleRadiusProperty, value); }
        }

        public static readonly BindableProperty DisabledAlphaProperty =
            BindableProperty.Create("DisabledAlpha", typeof(double), typeof(XfMDCButton), 0.0);

        public double DisabledAlpha
        {
            get { return (double)base.GetValue(DisabledAlphaProperty); }
            set { base.SetValue(DisabledAlphaProperty, value); }
        }

        public static readonly BindableProperty MinimumSizeProperty =
            BindableProperty.Create("MinimumSize", typeof(Size), typeof(XfMDCButton), null);

        public Size MinimumSize
        {
            get { return (Size)base.GetValue(MinimumSizeProperty); }
            set { base.SetValue(MinimumSizeProperty, value); }
        }

        public static readonly BindableProperty MaximumSizeProperty =
            BindableProperty.Create("MaximumSize", typeof(Size), typeof(XfMDCButton), null);

        public Size MaximumSize
        {
            get { return (Size)base.GetValue(MaximumSizeProperty); }
            set { base.SetValue(MaximumSizeProperty, value); }
        }

        public static readonly BindableProperty MaximumUnderlyingColorHintSizeProperty =
            BindableProperty.Create("MaximumUnderlyingColorHintSize", typeof(Color), typeof(XfMDCButton), null);

        public Color MaximumUnderlyingColorHintSize
        {
            get { return (Color)base.GetValue(MaximumUnderlyingColorHintSizeProperty); }
            set { base.SetValue(MaximumUnderlyingColorHintSizeProperty, value); }
        }

        public static readonly BindableProperty CustomTitleColorProperty =
            BindableProperty.Create("CustomTitleColor", typeof(Color), typeof(XfMDCButton), null);

        public Color CustomTitleColor
        {
            get { return (Color)base.GetValue(CustomTitleColorProperty); }
            set { base.SetValue(CustomTitleColorProperty, value); }
        }

        public static readonly BindableProperty ShouldRaiseOnTouchProperty =
            BindableProperty.Create("ShouldRaiseOnTouch", typeof(bool), typeof(XfMDCButton), false);

        public bool ShouldRaiseOnTouch
        {
            get { return (bool)base.GetValue(ShouldRaiseOnTouchProperty); }
            set { base.SetValue(ShouldRaiseOnTouchProperty, value); }
        }

        public static readonly BindableProperty ShouldCapitalizeTitleProperty =
            BindableProperty.Create("ShouldCapitalizeTitle", typeof(bool), typeof(XfMDCButton), false);

        public bool ShouldCapitalizeTitle
        {
            get { return (bool)base.GetValue(ShouldCapitalizeTitleProperty); }
            set { base.SetValue(ShouldCapitalizeTitleProperty, value); }
        }

        public static readonly BindableProperty UnderlyingColorProperty =
            BindableProperty.Create("UnderlyingColor", typeof(Color), typeof(XfMDCButton), null);

        public Color UnderlyingColor
        {
            get { return (Color)base.GetValue(UnderlyingColorProperty); }
            set { base.SetValue(UnderlyingColorProperty, value); }
        }

    }
}