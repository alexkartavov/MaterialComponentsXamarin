using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCActivityIndicator: View
    {
        public XfMDCActivityIndicator()
        {
        }

        public static readonly BindableProperty AnimatingProperty =
            BindableProperty.Create("Animating", typeof(bool), typeof(XfMDCActivityIndicator), false);

        public bool Animating
        {
            get { return (bool)base.GetValue(AnimatingProperty); }
            set { base.SetValue(AnimatingProperty, value); }
        }

        public static readonly BindableProperty RadiusProperty =
            BindableProperty.Create("Radius", typeof(double), typeof(XfMDCActivityIndicator), default(double));

        public double Radius
        {
            get { return (double)base.GetValue(RadiusProperty); }
            set { base.SetValue(RadiusProperty, value); }
        }

        public static readonly BindableProperty StrokeWidthProperty =
            BindableProperty.Create("StrokeWidth", typeof(double), typeof(XfMDCActivityIndicator), default(double));

        public double StrokeWidth
        {
            get { return (double)base.GetValue(StrokeWidthProperty); }
            set { base.SetValue(StrokeWidthProperty, value); }
        }

        public static readonly BindableProperty IndicatorModeProperty =
            BindableProperty.Create("IndicatorMode", typeof(MDCActivityIndicatorMode), typeof(XfMDCActivityIndicator), MDCActivityIndicatorMode.Indeterminate);

        public MDCActivityIndicatorMode IndicatorMode
        {
            get { return (MDCActivityIndicatorMode)base.GetValue(IndicatorModeProperty); }
            set { base.SetValue(IndicatorModeProperty, value); }
        }

        public static readonly BindableProperty CycleColorsProperty =
            BindableProperty.Create("CycleColors", typeof(Color[]), typeof(XfMDCActivityIndicator), null);

        public Color[] CycleColors
        {
            get { return (Color[])base.GetValue(CycleColorsProperty); }
            set { base.SetValue(CycleColorsProperty, value); }
        }

    }
}