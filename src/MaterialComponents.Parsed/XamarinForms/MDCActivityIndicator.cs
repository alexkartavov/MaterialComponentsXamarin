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
            BindableProperty.Create("Radius", typeof(float), typeof(XfMDCActivityIndicator), 3.0);

        public float Radius
        {
            get { return (float)base.GetValue(RadiusProperty); }
            set { base.SetValue(RadiusProperty, value); }
        }

        public static readonly BindableProperty StrokeWidthProperty =
            BindableProperty.Create("StrokeWidth", typeof(float), typeof(XfMDCActivityIndicator), 15.0);

        public float StrokeWidth
        {
            get { return (float)base.GetValue(StrokeWidthProperty); }
            set { base.SetValue(StrokeWidthProperty, value); }
        }

        public static readonly BindableProperty IndicatorModeProperty =
            BindableProperty.Create("IndicatorMode", typeof(MDCActivityIndicatorMode), typeof(XfMDCActivityIndicator), MDCActivityIndicatorMode.Indeterminate);

        public MDCActivityIndicatorMode IndicatorMode
        {
            get { return (MDCActivityIndicatorMode)base.GetValue(IndicatorModeProperty); }
            set { base.SetValue(IndicatorModeProperty, value); }
        }

        public static readonly BindableProperty TrackEnabledProperty =
            BindableProperty.Create("TrackEnabled", typeof(bool), typeof(XfMDCActivityIndicator), false);

        public bool TrackEnabled
        {
            get { return (bool)base.GetValue(TrackEnabledProperty); }
            set { base.SetValue(TrackEnabledProperty, value); }
        }

        public static readonly BindableProperty ProgressProperty =
            BindableProperty.Create("Progress", typeof(float), typeof(XfMDCActivityIndicator), default(float));

        public float Progress
        {
            get { return (float)base.GetValue(ProgressProperty); }
            set { base.SetValue(ProgressProperty, value); }
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