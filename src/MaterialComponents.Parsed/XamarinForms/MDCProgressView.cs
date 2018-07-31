using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCProgressView: View
    {
        public XfMDCProgressView()
        {
        }

        public static readonly BindableProperty ProgressTintColorProperty =
            BindableProperty.Create("ProgressTintColor", typeof(Color), typeof(XfMDCProgressView), Color.Default);

        public Color ProgressTintColor
        {
            get { return (Color)base.GetValue(ProgressTintColorProperty); }
            set { base.SetValue(ProgressTintColorProperty, value); }
        }

        public static readonly BindableProperty TrackTintColorProperty =
            BindableProperty.Create("TrackTintColor", typeof(Color), typeof(XfMDCProgressView), Color.Default);

        public Color TrackTintColor
        {
            get { return (Color)base.GetValue(TrackTintColorProperty); }
            set { base.SetValue(TrackTintColorProperty, value); }
        }

        public static readonly BindableProperty ProgressProperty =
            BindableProperty.Create("Progress", typeof(float), typeof(XfMDCProgressView), default(float));

        public float Progress
        {
            get { return (float)base.GetValue(ProgressProperty); }
            set { base.SetValue(ProgressProperty, value); }
        }

        public static readonly BindableProperty BackwardProgressAnimationModeProperty =
            BindableProperty.Create("BackwardProgressAnimationMode", typeof(MDCProgressViewBackwardAnimationMode), typeof(XfMDCProgressView), MDCProgressViewBackwardAnimationMode.Reset);

        public MDCProgressViewBackwardAnimationMode BackwardProgressAnimationMode
        {
            get { return (MDCProgressViewBackwardAnimationMode)base.GetValue(BackwardProgressAnimationModeProperty); }
            set { base.SetValue(BackwardProgressAnimationModeProperty, value); }
        }

    }
}