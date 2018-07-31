using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCSlider: View
    {
        public XfMDCSlider()
        {
        }

        public static readonly BindableProperty InkColorProperty =
            BindableProperty.Create("InkColor", typeof(Color), typeof(XfMDCSlider), Color.Default);

        public Color InkColor
        {
            get { return (Color)base.GetValue(InkColorProperty); }
            set { base.SetValue(InkColorProperty, value); }
        }

        public static readonly BindableProperty ThumbRadiusProperty =
            BindableProperty.Create("ThumbRadius", typeof(float), typeof(XfMDCSlider), 10.0f);

        public float ThumbRadius
        {
            get { return (float)base.GetValue(ThumbRadiusProperty); }
            set { base.SetValue(ThumbRadiusProperty, value); }
        }

        public static readonly BindableProperty ThumbElevationProperty =
            BindableProperty.Create("ThumbElevation", typeof(double), typeof(XfMDCSlider), 2.0);

        public double ThumbElevation
        {
            get { return (double)base.GetValue(ThumbElevationProperty); }
            set { base.SetValue(ThumbElevationProperty, value); }
        }

        public static readonly BindableProperty NumberOfDiscreteValuesProperty =
            BindableProperty.Create("NumberOfDiscreteValues", typeof(uint), typeof(XfMDCSlider), default(uint));

        public uint NumberOfDiscreteValues
        {
            get { return (uint)base.GetValue(NumberOfDiscreteValuesProperty); }
            set { base.SetValue(NumberOfDiscreteValuesProperty, value); }
        }

        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create("Value", typeof(float), typeof(XfMDCSlider), default(float));

        public float Value
        {
            get { return (float)base.GetValue(ValueProperty); }
            set { base.SetValue(ValueProperty, value); }
        }

        public static readonly BindableProperty MinimumValueProperty =
            BindableProperty.Create("MinimumValue", typeof(float), typeof(XfMDCSlider), default(float));

        public float MinimumValue
        {
            get { return (float)base.GetValue(MinimumValueProperty); }
            set { base.SetValue(MinimumValueProperty, value); }
        }

        public static readonly BindableProperty MaximumValueProperty =
            BindableProperty.Create("MaximumValue", typeof(float), typeof(XfMDCSlider), default(float));

        public float MaximumValue
        {
            get { return (float)base.GetValue(MaximumValueProperty); }
            set { base.SetValue(MaximumValueProperty, value); }
        }

        public static readonly BindableProperty ContinuousProperty =
            BindableProperty.Create("Continuous", typeof(bool), typeof(XfMDCSlider), false);

        public bool Continuous
        {
            get { return (bool)base.GetValue(ContinuousProperty); }
            set { base.SetValue(ContinuousProperty, value); }
        }

        public static readonly BindableProperty FilledTrackAnchorValueProperty =
            BindableProperty.Create("FilledTrackAnchorValue", typeof(float), typeof(XfMDCSlider), default(float));

        public float FilledTrackAnchorValue
        {
            get { return (float)base.GetValue(FilledTrackAnchorValueProperty); }
            set { base.SetValue(FilledTrackAnchorValueProperty, value); }
        }

        public static readonly BindableProperty ShouldDisplayDiscreteValueLabelProperty =
            BindableProperty.Create("ShouldDisplayDiscreteValueLabel", typeof(bool), typeof(XfMDCSlider), false);

        public bool ShouldDisplayDiscreteValueLabel
        {
            get { return (bool)base.GetValue(ShouldDisplayDiscreteValueLabelProperty); }
            set { base.SetValue(ShouldDisplayDiscreteValueLabelProperty, value); }
        }

        public static readonly BindableProperty ValueLabelTextColorProperty =
            BindableProperty.Create("ValueLabelTextColor", typeof(Color), typeof(XfMDCSlider), Color.Default);

        public Color ValueLabelTextColor
        {
            get { return (Color)base.GetValue(ValueLabelTextColorProperty); }
            set { base.SetValue(ValueLabelTextColorProperty, value); }
        }

        public static readonly BindableProperty ValueLabelBackgroundColorProperty =
            BindableProperty.Create("ValueLabelBackgroundColor", typeof(Color), typeof(XfMDCSlider), Color.Default);

        public Color ValueLabelBackgroundColor
        {
            get { return (Color)base.GetValue(ValueLabelBackgroundColorProperty); }
            set { base.SetValue(ValueLabelBackgroundColorProperty, value); }
        }

        public static readonly BindableProperty ThumbHollowAtStartProperty =
            BindableProperty.Create("ThumbHollowAtStart", typeof(bool), typeof(XfMDCSlider), false);

        public bool ThumbHollowAtStart
        {
            get { return (bool)base.GetValue(ThumbHollowAtStartProperty); }
            set { base.SetValue(ThumbHollowAtStartProperty, value); }
        }

        public static readonly BindableProperty DisabledColorProperty =
            BindableProperty.Create("DisabledColor", typeof(Color), typeof(XfMDCSlider), Color.Default);

        public Color DisabledColor
        {
            get { return (Color)base.GetValue(DisabledColorProperty); }
            set { base.SetValue(DisabledColorProperty, value); }
        }

        public static readonly BindableProperty ColorProperty =
            BindableProperty.Create("Color", typeof(Color), typeof(XfMDCSlider), Color.Default);

        public Color Color
        {
            get { return (Color)base.GetValue(ColorProperty); }
            set { base.SetValue(ColorProperty, value); }
        }

        public static readonly BindableProperty TrackBackgroundColorProperty =
            BindableProperty.Create("TrackBackgroundColor", typeof(Color), typeof(XfMDCSlider), Color.Default);

        public Color TrackBackgroundColor
        {
            get { return (Color)base.GetValue(TrackBackgroundColorProperty); }
            set { base.SetValue(TrackBackgroundColorProperty, value); }
        }

    }
}