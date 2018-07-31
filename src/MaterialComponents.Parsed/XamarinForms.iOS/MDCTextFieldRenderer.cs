using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCTextField), typeof(MDCTextFieldRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCTextFieldRenderer : ViewRenderer<XfMDCTextField, MDCTextField>
    {
        public MDCTextFieldRenderer()
        {
        }

        protected override MDCTextField CreateNativeControl()
        {
            return new MDCTextField();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCTextField> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(CreateNativeControl());
                }

                UpdateCursorColor();
                UpdateEnabled();
                UpdateHidesPlaceholderOnInput();
                UpdatePlaceholder();
                UpdateText();
                UpdateTextColor();
            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == XfMDCTextField.CursorColorProperty.PropertyName)
            {
                UpdateCursorColor();
            }
            else if (e.PropertyName == XfMDCTextField.EnabledProperty.PropertyName)
            {
                UpdateEnabled();
            }
            else if (e.PropertyName == XfMDCTextField.HidesPlaceholderOnInputProperty.PropertyName)
            {
                UpdateHidesPlaceholderOnInput();
            }
            else if (e.PropertyName == XfMDCTextField.PlaceholderProperty.PropertyName)
            {
                UpdatePlaceholder();
            }
            else if (e.PropertyName == XfMDCTextField.TextProperty.PropertyName)
            {
                UpdateText();
            }
            else if (e.PropertyName == XfMDCTextField.TextColorProperty.PropertyName)
            {
                UpdateTextColor();
            }
            
        }

        void UpdateCursorColor()
        {
            Control.CursorColor = Element.CursorColor.ToUIColor();
        }

        void UpdateEnabled()
        {
            Control.Enabled = Element.Enabled;
        }

        void UpdateHidesPlaceholderOnInput()
        {
            Control.HidesPlaceholderOnInput = Element.HidesPlaceholderOnInput;
        }

        void UpdatePlaceholder()
        {
            Control.Placeholder = Element.Placeholder;
        }

        void UpdateText()
        {
            Control.Text = Element.Text;
        }

        void UpdateTextColor()
        {
            Control.TextColor = Element.TextColor.ToUIColor();
        }

    }
}