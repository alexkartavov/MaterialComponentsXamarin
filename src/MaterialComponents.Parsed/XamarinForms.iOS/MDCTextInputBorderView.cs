using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCTextInputBorderView), typeof(MDCTextInputBorderViewRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCTextInputBorderViewRenderer : ViewRenderer<XfMDCTextInputBorderView, MDCTextInputBorderView>
    {
        public MDCTextInputBorderViewRenderer()
        {
        }

        protected override MDCTextInputBorderView CreateNativeControl()
        {
            return new MDCTextInputBorderView();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCTextInputBorderView> e)
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