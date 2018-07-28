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

            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

        }

    }
}