using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCIntrinsicHeightTextView), typeof(MDCIntrinsicHeightTextViewRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCIntrinsicHeightTextViewRenderer : ViewRenderer<XfMDCIntrinsicHeightTextView, MDCIntrinsicHeightTextView>
    {
        public MDCIntrinsicHeightTextViewRenderer()
        {
        }

        protected override MDCIntrinsicHeightTextView CreateNativeControl()
        {
            return new MDCIntrinsicHeightTextView();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCIntrinsicHeightTextView> e)
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