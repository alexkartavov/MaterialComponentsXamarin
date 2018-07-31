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

                UpdateProgressTintColor();
                UpdateTrackTintColor();
                UpdateProgress();
                UpdateBackwardProgressAnimationMode();
            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == XfMDCProgressView.ProgressTintColorProperty.PropertyName)
            {
                UpdateProgressTintColor();
            }
            else if (e.PropertyName == XfMDCProgressView.TrackTintColorProperty.PropertyName)
            {
                UpdateTrackTintColor();
            }
            else if (e.PropertyName == XfMDCProgressView.ProgressProperty.PropertyName)
            {
                UpdateProgress();
            }
            else if (e.PropertyName == XfMDCProgressView.BackwardProgressAnimationModeProperty.PropertyName)
            {
                UpdateBackwardProgressAnimationMode();
            }
            
        }

        void UpdateProgressTintColor()
        {
            Control.ProgressTintColor = Element.ProgressTintColor.ToUIColor();
        }

        void UpdateTrackTintColor()
        {
            Control.TrackTintColor = Element.TrackTintColor.ToUIColor();
        }

        void UpdateProgress()
        {
            Control.Progress = Element.Progress;
        }

        void UpdateBackwardProgressAnimationMode()
        {
            Control.BackwardProgressAnimationMode = Element.BackwardProgressAnimationMode;
        }

    }
}