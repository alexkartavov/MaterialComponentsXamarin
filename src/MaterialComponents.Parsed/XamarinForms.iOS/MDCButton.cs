using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCButton), typeof(MDCButtonRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCButtonRenderer : ViewRenderer<XfMDCButton, MDCButton>
    {
        public MDCButtonRenderer()
        {
        }

        protected override MDCButton CreateNativeControl()
        {
            return new MDCButton();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCButton> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(CreateNativeControl());
                }

                UpdateInkColor();
                UpdateInkMaxRippleRadius();
                UpdateDisabledAlpha();
                UpdateMinimumSize();
                UpdateMaximumSize();
                UpdateMaximumUnderlyingColorHintSize();
                UpdateCustomTitleColor();
                UpdateShouldRaiseOnTouch();
                UpdateShouldCapitalizeTitle();
                UpdateUnderlyingColor();
            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == XfMDCButton.InkColorProperty.PropertyName)
            {
                UpdateInkColor();
            }
            else if (e.PropertyName == XfMDCButton.InkMaxRippleRadiusProperty.PropertyName)
            {
                UpdateInkMaxRippleRadius();
            }
            else if (e.PropertyName == XfMDCButton.DisabledAlphaProperty.PropertyName)
            {
                UpdateDisabledAlpha();
            }
            else if (e.PropertyName == XfMDCButton.MinimumSizeProperty.PropertyName)
            {
                UpdateMinimumSize();
            }
            else if (e.PropertyName == XfMDCButton.MaximumSizeProperty.PropertyName)
            {
                UpdateMaximumSize();
            }
            else if (e.PropertyName == XfMDCButton.MaximumUnderlyingColorHintSizeProperty.PropertyName)
            {
                UpdateMaximumUnderlyingColorHintSize();
            }
            else if (e.PropertyName == XfMDCButton.CustomTitleColorProperty.PropertyName)
            {
                UpdateCustomTitleColor();
            }
            else if (e.PropertyName == XfMDCButton.ShouldRaiseOnTouchProperty.PropertyName)
            {
                UpdateShouldRaiseOnTouch();
            }
            else if (e.PropertyName == XfMDCButton.ShouldCapitalizeTitleProperty.PropertyName)
            {
                UpdateShouldCapitalizeTitle();
            }
            else if (e.PropertyName == XfMDCButton.UnderlyingColorProperty.PropertyName)
            {
                UpdateUnderlyingColor();
            }
            
        }

        void UpdateInkColor()
        {
        }
        void UpdateInkMaxRippleRadius()
        {
        }
        void UpdateDisabledAlpha()
        {
        }
        void UpdateMinimumSize()
        {
        }
        void UpdateMaximumSize()
        {
        }
        void UpdateMaximumUnderlyingColorHintSize()
        {
        }
        void UpdateCustomTitleColor()
        {
        }
        void UpdateShouldRaiseOnTouch()
        {
        }
        void UpdateShouldCapitalizeTitle()
        {
        }
        void UpdateUnderlyingColor()
        {
        }
    }
}