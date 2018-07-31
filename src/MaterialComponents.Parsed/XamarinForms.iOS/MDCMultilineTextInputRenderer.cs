using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCMultilineTextInput), typeof(MDCMultilineTextInputRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCMultilineTextInputRenderer : ViewRenderer<XfMDCMultilineTextInput, MDCMultilineTextInput>
    {
        public MDCMultilineTextInputRenderer()
        {
        }

        protected override MDCMultilineTextInput CreateNativeControl()
        {
            return new MDCMultilineTextInput();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCMultilineTextInput> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(CreateNativeControl());
                }

                UpdateExpandsOnOverflow();
                UpdateMinimumLines();
            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == XfMDCMultilineTextInput.ExpandsOnOverflowProperty.PropertyName)
            {
                UpdateExpandsOnOverflow();
            }
            else if (e.PropertyName == XfMDCMultilineTextInput.MinimumLinesProperty.PropertyName)
            {
                UpdateMinimumLines();
            }
            
        }

        void UpdateExpandsOnOverflow()
        {
            Control.ExpandsOnOverflow = Element.ExpandsOnOverflow;
        }

        void UpdateMinimumLines()
        {
            Control.MinimumLines = Element.MinimumLines;
        }

    }
}