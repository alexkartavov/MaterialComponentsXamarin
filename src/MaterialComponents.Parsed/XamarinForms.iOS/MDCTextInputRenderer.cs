using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCTextInput), typeof(MDCTextInputRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCTextInputRenderer : ViewRenderer<XfMDCTextInput, MDCTextInput>
    {
        public MDCTextInputRenderer()
        {
        }

        protected override MDCTextInput CreateNativeControl()
        {
            return new MDCTextInput();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCTextInput> e)
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

            if (e.PropertyName == XfMDCTextInput.CursorColorProperty.PropertyName)
            {
                UpdateCursorColor();
            }
            else if (e.PropertyName == XfMDCTextInput.EnabledProperty.PropertyName)
            {
                UpdateEnabled();
            }
            else if (e.PropertyName == XfMDCTextInput.HidesPlaceholderOnInputProperty.PropertyName)
            {
                UpdateHidesPlaceholderOnInput();
            }
            else if (e.PropertyName == XfMDCTextInput.PlaceholderProperty.PropertyName)
            {
                UpdatePlaceholder();
            }
            else if (e.PropertyName == XfMDCTextInput.TextProperty.PropertyName)
            {
                UpdateText();
            }
            else if (e.PropertyName == XfMDCTextInput.TextColorProperty.PropertyName)
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