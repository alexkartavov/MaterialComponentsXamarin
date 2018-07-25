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

            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

        }

    }
}