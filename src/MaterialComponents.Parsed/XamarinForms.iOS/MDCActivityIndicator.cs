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
            else if (e.PropertyName == XfMDCActivityIndicator.CycleColorsProperty.PropertyName)
            {
                UpdateCycleColors();
            }
            
        }

        void UpdateAnimating()
        {
        }
        void UpdateRadius()
        {
        }
        void UpdateStrokeWidth()
        {
        }
        void UpdateIndicatorMode()
        {
        }
        void UpdateCycleColors()
        {
        }
    }
}