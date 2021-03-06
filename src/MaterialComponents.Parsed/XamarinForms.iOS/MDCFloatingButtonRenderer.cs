using System;
using System.ComponentModel;
using System.Drawing;
using MaterialComponents;
using MaterialComponents.Forms;
using MaterialComponents.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(XfMDCFloatingButton), typeof(MDCFloatingButtonRenderer))]

namespace MaterialComponents.iOS
{
    public class MDCFloatingButtonRenderer : ViewRenderer<XfMDCFloatingButton, MDCFloatingButton>
    {
        public MDCFloatingButtonRenderer()
        {
        }

        protected override MDCFloatingButton CreateNativeControl()
        {
            return new MDCFloatingButton();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XfMDCFloatingButton> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(CreateNativeControl());
                }

                UpdateMode();
                UpdateImageLocation();
            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == XfMDCFloatingButton.ModeProperty.PropertyName)
            {
                UpdateMode();
            }
            else if (e.PropertyName == XfMDCFloatingButton.ImageLocationProperty.PropertyName)
            {
                UpdateImageLocation();
            }
            
        }

        void UpdateMode()
        {
            Control.Mode = Element.Mode;
        }

        void UpdateImageLocation()
        {
            Control.ImageLocation = Element.ImageLocation;
        }

    }
}