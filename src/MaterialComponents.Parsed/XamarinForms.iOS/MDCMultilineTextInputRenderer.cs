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

            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

        }

    }
}