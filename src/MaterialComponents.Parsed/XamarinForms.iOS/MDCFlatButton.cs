using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCFlatButton), typeof(MDCFlatButtonRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCFlatButtonRenderer : ViewRenderer<XfMDCFlatButton, MDCFlatButton>
    {
        public MDCFlatButtonRenderer()
        {
        }

        protected override MDCFlatButton CreateNativeControl()
        {
            return new MDCFlatButton();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCFlatButton> e)
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