using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCProgressView), typeof(MDCProgressViewRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCProgressViewRenderer : ViewRenderer<XfMDCProgressView, MDCProgressView>
    {
        public MDCProgressViewRenderer()
        {
        }

        protected override MDCProgressView CreateNativeControl()
        {
            return new MDCProgressView();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCProgressView> e)
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