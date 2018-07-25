using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCTextInputUnderlineView), typeof(MDCTextInputUnderlineViewRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCTextInputUnderlineViewRenderer : ViewRenderer<XfMDCTextInputUnderlineView, MDCTextInputUnderlineView>
    {
        public MDCTextInputUnderlineViewRenderer()
        {
        }

        protected override MDCTextInputUnderlineView CreateNativeControl()
        {
            return new MDCTextInputUnderlineView();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCTextInputUnderlineView> e)
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