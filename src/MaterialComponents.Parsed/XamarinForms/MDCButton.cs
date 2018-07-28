using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCButton: View
    {
        public XfMDCButton()
        {
        }

        public static readonly BindableProperty InkStyleProperty =
            BindableProperty.Create("InkStyle", typeof(MDCInkStyle), typeof(XfMDCButton), MDCInkStyle.Bounded);

        public MDCInkStyle InkStyle
        {
            get { return (MDCInkStyle)base.GetValue(InkStyleProperty); }
            set { base.SetValue(InkStyleProperty, value); }
        }

        public static readonly BindableProperty InkColorProperty =
            BindableProperty.Create("InkColor", typeof(Color), typeof(XfMDCButton), Color.Default);

        public Color InkColor
        {
            get { return (Color)base.GetValue(InkColorProperty); }
            set { base.SetValue(InkColorProperty, value); }
        }

        public static readonly BindableProperty InkMaxRippleRadiusProperty =
            BindableProperty.Create("InkMaxRippleRadius", typeof(float), typeof(XfMDCButton), 10.0);

        public float InkMaxRippleRadius
        {
            get { return (float)base.GetValue(InkMaxRippleRadiusProperty); }
            set { base.SetValue(InkMaxRippleRadiusProperty, value); }
        }

        public static readonly BindableProperty DisabledAlphaProperty =
            BindableProperty.Create("DisabledAlpha", typeof(float), typeof(XfMDCButton), 0.8);

        public float DisabledAlpha
        {
            get { return (float)base.GetValue(DisabledAlphaProperty); }
            set { base.SetValue(DisabledAlphaProperty, value); }
        }

        public static readonly BindableProperty MinimumSizeProperty =
            BindableProperty.Create("MinimumSize", typeof(Size), typeof(XfMDCButton), Size.Zero);

        public Size MinimumSize
        {
            get { return (Size)base.GetValue(MinimumSizeProperty); }
            set { base.SetValue(MinimumSizeProperty, value); }
        }

        public static readonly BindableProperty MaximumSizeProperty =
            BindableProperty.Create("MaximumSize", typeof(Size), typeof(XfMDCButton), Size.Zero);

        public Size MaximumSize
        {
            get { return (Size)base.GetValue(MaximumSizeProperty); }
            set { base.SetValue(MaximumSizeProperty, value); }
        }

        public static readonly BindableProperty UnderlyingColorHintProperty =
            BindableProperty.Create("UnderlyingColorHint", typeof(Color), typeof(XfMDCButton), Color.Default);

        public Color UnderlyingColorHint
        {
            get { return (Color)base.GetValue(UnderlyingColorHintProperty); }
            set { base.SetValue(UnderlyingColorHintProperty, value); }
        }

        public static readonly BindableProperty CustomTitleColorProperty =
            BindableProperty.Create("CustomTitleColor", typeof(Color), typeof(XfMDCButton), Color.Default);

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
            BindableProperty.Create("UnderlyingColor", typeof(Color), typeof(XfMDCButton), Color.Default);

        public Color UnderlyingColor
        {
            get { return (Color)base.GetValue(UnderlyingColorProperty); }
            set { base.SetValue(UnderlyingColorProperty, value); }
        }

    }
}