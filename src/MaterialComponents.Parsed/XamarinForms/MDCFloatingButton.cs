using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCFloatingButton: View
    {
        public XfMDCFloatingButton()
        {
        }

        public static readonly BindableProperty ModeProperty =
            BindableProperty.Create("Mode", typeof(MDCFloatingButtonMode), typeof(XfMDCFloatingButton), MDCFloatingButtonMode.Normal);

        public MDCFloatingButtonMode Mode
        {
            get { return (MDCFloatingButtonMode)base.GetValue(ModeProperty); }
            set { base.SetValue(ModeProperty, value); }
        }

        public static readonly BindableProperty ImageLocationProperty =
            BindableProperty.Create("ImageLocation", typeof(MDCFloatingButtonImageLocation), typeof(XfMDCFloatingButton), MDCFloatingButtonImageLocation.Leading);

        public MDCFloatingButtonImageLocation ImageLocation
        {
            get { return (MDCFloatingButtonImageLocation)base.GetValue(ImageLocationProperty); }
            set { base.SetValue(ImageLocationProperty, value); }
        }

    }
}