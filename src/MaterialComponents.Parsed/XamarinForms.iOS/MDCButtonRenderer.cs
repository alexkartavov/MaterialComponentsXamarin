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

                UpdateInkStyle();
                UpdateInkColor();
                UpdateInkMaxRippleRadius();
                UpdateDisabledAlpha();
                UpdateMinimumSize();
                UpdateMaximumSize();
                UpdateUnderlyingColorHint();
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

            if (e.PropertyName == XfMDCButton.InkStyleProperty.PropertyName)
            {
                UpdateInkStyle();
            }
            else if (e.PropertyName == XfMDCButton.InkColorProperty.PropertyName)
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
            else if (e.PropertyName == XfMDCButton.UnderlyingColorHintProperty.PropertyName)
            {
                UpdateUnderlyingColorHint();
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

        void UpdateInkStyle()
        {
            Control.InkStyle = Element.InkStyle;
        }

        void UpdateInkColor()
        {
            Control.InkColor = Element.InkColor.ToUIColor();
        }

        void UpdateInkMaxRippleRadius()
        {
            Control.InkMaxRippleRadius = Element.InkMaxRippleRadius;
        }

        void UpdateDisabledAlpha()
        {
            Control.DisabledAlpha = Element.DisabledAlpha;
        }

        void UpdateMinimumSize()
        {
            Control.MinimumSize = Element.MinimumSize;
        }

        void UpdateMaximumSize()
        {
            Control.MaximumSize = Element.MaximumSize;
        }

        void UpdateUnderlyingColorHint()
        {
            Control.UnderlyingColorHint = Element.UnderlyingColorHint.ToUIColor();
        }

        void UpdateCustomTitleColor()
        {
            Control.CustomTitleColor = Element.CustomTitleColor.ToUIColor();
        }

        void UpdateShouldRaiseOnTouch()
        {
            Control.ShouldRaiseOnTouch = Element.ShouldRaiseOnTouch;
        }

        void UpdateShouldCapitalizeTitle()
        {
            Control.ShouldCapitalizeTitle = Element.ShouldCapitalizeTitle;
        }

        void UpdateUnderlyingColor()
        {
            Control.UnderlyingColor = Element.UnderlyingColor.ToUIColor();
        }

    }
}