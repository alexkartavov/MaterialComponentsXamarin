using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCSlider), typeof(MDCSliderRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCSliderRenderer : ViewRenderer<XfMDCSlider, MDCSlider>
    {
        public MDCSliderRenderer()
        {
        }

        protected override MDCSlider CreateNativeControl()
        {
            return new MDCSlider();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCSlider> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(CreateNativeControl());
                }

                UpdateInkColor();
                UpdateThumbRadius();
                UpdateThumbElevation();
                UpdateNumberOfDiscreteValues();
                UpdateValue();
                UpdateMinimumValue();
                UpdateMaximumValue();
                UpdateContinuous();
                UpdateFilledTrackAnchorValue();
                UpdateShouldDisplayDiscreteValueLabel();
                UpdateValueLabelTextColor();
                UpdateValueLabelBackgroundColor();
                UpdateThumbHollowAtStart();
                UpdateDisabledColor();
                UpdateColor();
                UpdateTrackBackgroundColor();
            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == XfMDCSlider.InkColorProperty.PropertyName)
            {
                UpdateInkColor();
            }
            else if (e.PropertyName == XfMDCSlider.ThumbRadiusProperty.PropertyName)
            {
                UpdateThumbRadius();
            }
            else if (e.PropertyName == XfMDCSlider.ThumbElevationProperty.PropertyName)
            {
                UpdateThumbElevation();
            }
            else if (e.PropertyName == XfMDCSlider.NumberOfDiscreteValuesProperty.PropertyName)
            {
                UpdateNumberOfDiscreteValues();
            }
            else if (e.PropertyName == XfMDCSlider.ValueProperty.PropertyName)
            {
                UpdateValue();
            }
            else if (e.PropertyName == XfMDCSlider.MinimumValueProperty.PropertyName)
            {
                UpdateMinimumValue();
            }
            else if (e.PropertyName == XfMDCSlider.MaximumValueProperty.PropertyName)
            {
                UpdateMaximumValue();
            }
            else if (e.PropertyName == XfMDCSlider.ContinuousProperty.PropertyName)
            {
                UpdateContinuous();
            }
            else if (e.PropertyName == XfMDCSlider.FilledTrackAnchorValueProperty.PropertyName)
            {
                UpdateFilledTrackAnchorValue();
            }
            else if (e.PropertyName == XfMDCSlider.ShouldDisplayDiscreteValueLabelProperty.PropertyName)
            {
                UpdateShouldDisplayDiscreteValueLabel();
            }
            else if (e.PropertyName == XfMDCSlider.ValueLabelTextColorProperty.PropertyName)
            {
                UpdateValueLabelTextColor();
            }
            else if (e.PropertyName == XfMDCSlider.ValueLabelBackgroundColorProperty.PropertyName)
            {
                UpdateValueLabelBackgroundColor();
            }
            else if (e.PropertyName == XfMDCSlider.ThumbHollowAtStartProperty.PropertyName)
            {
                UpdateThumbHollowAtStart();
            }
            else if (e.PropertyName == XfMDCSlider.DisabledColorProperty.PropertyName)
            {
                UpdateDisabledColor();
            }
            else if (e.PropertyName == XfMDCSlider.ColorProperty.PropertyName)
            {
                UpdateColor();
            }
            else if (e.PropertyName == XfMDCSlider.TrackBackgroundColorProperty.PropertyName)
            {
                UpdateTrackBackgroundColor();
            }
            
        }

        void UpdateInkColor()
        {
            Control.InkColor = Element.InkColor.ToUIColor();
        }

        void UpdateThumbRadius()
        {
            Control.ThumbRadius = Element.ThumbRadius;
        }

        void UpdateThumbElevation()
        {
            Control.ThumbElevation = Element.ThumbElevation;
        }

        void UpdateNumberOfDiscreteValues()
        {
            Control.NumberOfDiscreteValues = Element.NumberOfDiscreteValues;
        }

        void UpdateValue()
        {
            Control.Value = Element.Value;
        }

        void UpdateMinimumValue()
        {
            Control.MinimumValue = Element.MinimumValue;
        }

        void UpdateMaximumValue()
        {
            Control.MaximumValue = Element.MaximumValue;
        }

        void UpdateContinuous()
        {
            Control.Continuous = Element.Continuous;
        }

        void UpdateFilledTrackAnchorValue()
        {
            Control.FilledTrackAnchorValue = Element.FilledTrackAnchorValue;
        }

        void UpdateShouldDisplayDiscreteValueLabel()
        {
            Control.ShouldDisplayDiscreteValueLabel = Element.ShouldDisplayDiscreteValueLabel;
        }

        void UpdateValueLabelTextColor()
        {
            Control.ValueLabelTextColor = Element.ValueLabelTextColor.ToUIColor();
        }

        void UpdateValueLabelBackgroundColor()
        {
            Control.ValueLabelBackgroundColor = Element.ValueLabelBackgroundColor.ToUIColor();
        }

        void UpdateThumbHollowAtStart()
        {
            Control.ThumbHollowAtStart = Element.ThumbHollowAtStart;
        }

        void UpdateDisabledColor()
        {
            Control.DisabledColor = Element.DisabledColor.ToUIColor();
        }

        void UpdateColor()
        {
            Control.Color = Element.Color.ToUIColor();
        }

        void UpdateTrackBackgroundColor()
        {
            Control.TrackBackgroundColor = Element.TrackBackgroundColor.ToUIColor();
        }

    }
}