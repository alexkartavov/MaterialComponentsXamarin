using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCMultilineTextField), typeof(MDCMultilineTextFieldRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCMultilineTextFieldRenderer : ViewRenderer<XfMDCMultilineTextField, MDCMultilineTextField>
    {
        public MDCMultilineTextFieldRenderer()
        {
        }

        protected override MDCMultilineTextField CreateNativeControl()
        {
            return new MDCMultilineTextField();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCMultilineTextField> e)
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