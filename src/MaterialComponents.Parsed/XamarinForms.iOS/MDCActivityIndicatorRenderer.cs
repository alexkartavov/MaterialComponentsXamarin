using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCActivityIndicator), typeof(MDCActivityIndicatorRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCActivityIndicatorRenderer : ViewRenderer<XfMDCActivityIndicator, MDCActivityIndicator>
    {
        public MDCActivityIndicatorRenderer()
        {
        }

        protected override MDCActivityIndicator CreateNativeControl()
        {
            return new MDCActivityIndicator();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCActivityIndicator> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(CreateNativeControl());
                }

                UpdateAnimating();
                UpdateRadius();
                UpdateStrokeWidth();
                UpdateIndicatorMode();
                UpdateTrackEnabled();
                UpdateProgress();
                UpdateCycleColors();
            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == XfMDCActivityIndicator.AnimatingProperty.PropertyName)
            {
                UpdateAnimating();
            }
            else if (e.PropertyName == XfMDCActivityIndicator.RadiusProperty.PropertyName)
            {
                UpdateRadius();
            }
            else if (e.PropertyName == XfMDCActivityIndicator.StrokeWidthProperty.PropertyName)
            {
                UpdateStrokeWidth();
            }
            else if (e.PropertyName == XfMDCActivityIndicator.IndicatorModeProperty.PropertyName)
            {
                UpdateIndicatorMode();
            }
            else if (e.PropertyName == XfMDCActivityIndicator.TrackEnabledProperty.PropertyName)
            {
                UpdateTrackEnabled();
            }
            else if (e.PropertyName == XfMDCActivityIndicator.ProgressProperty.PropertyName)
            {
                UpdateProgress();
            }
            else if (e.PropertyName == XfMDCActivityIndicator.CycleColorsProperty.PropertyName)
            {
                UpdateCycleColors();
            }
            
        }

        void UpdateAnimating()
        {
            Control.Animating = Element.Animating;
        }

        void UpdateRadius()
        {
            Control.Radius = Element.Radius;
        }

        void UpdateStrokeWidth()
        {
            Control.StrokeWidth = Element.StrokeWidth;
        }

        void UpdateIndicatorMode()
        {
            Control.IndicatorMode = Element.IndicatorMode;
        }

        void UpdateTrackEnabled()
        {
            Control.TrackEnabled = Element.TrackEnabled;
        }

        void UpdateProgress()
        {
            Control.Progress = Element.Progress;
        }

        void UpdateCycleColors()
        {
            Control.CycleColors = Element.CycleColors;
        }

    }
}