using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCSlider), typeof(MDCSliderRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCSliderRenderer : ViewRenderer<XfMDCSlider, MDCSlider>
    {
        public MDCSliderRenderer()
        {
        }

        protected override MDCSlider CreateNativeControl()
        {
            return new MDCSlider();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCSlider> e)
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