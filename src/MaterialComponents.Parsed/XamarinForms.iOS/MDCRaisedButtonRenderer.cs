using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCRaisedButton), typeof(MDCRaisedButtonRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCRaisedButtonRenderer : ViewRenderer<XfMDCRaisedButton, MDCRaisedButton>
    {
        public MDCRaisedButtonRenderer()
        {
        }

        protected override MDCRaisedButton CreateNativeControl()
        {
            return new MDCRaisedButton();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCRaisedButton> e)
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