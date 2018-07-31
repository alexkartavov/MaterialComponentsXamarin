using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCTextField: View
    {
        public XfMDCTextField()
        {
        }

        public static readonly BindableProperty CursorColorProperty =
            BindableProperty.Create("CursorColor", typeof(Color), typeof(XfMDCTextField), Color.Default);

        public Color CursorColor
        {
            get { return (Color)base.GetValue(CursorColorProperty); }
            set { base.SetValue(CursorColorProperty, value); }
        }

        public static readonly BindableProperty EnabledProperty =
            BindableProperty.Create("Enabled", typeof(bool), typeof(XfMDCTextField), true);

        public bool Enabled
        {
            get { return (bool)base.GetValue(EnabledProperty); }
            set { base.SetValue(EnabledProperty, value); }
        }

        public static readonly BindableProperty HidesPlaceholderOnInputProperty =
            BindableProperty.Create("HidesPlaceholderOnInput", typeof(bool), typeof(XfMDCTextField), true);

        public bool HidesPlaceholderOnInput
        {
            get { return (bool)base.GetValue(HidesPlaceholderOnInputProperty); }
            set { base.SetValue(HidesPlaceholderOnInputProperty, value); }
        }

        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create("Placeholder", typeof(string), typeof(XfMDCTextField), null);

        public string Placeholder
        {
            get { return (string)base.GetValue(PlaceholderProperty); }
            set { base.SetValue(PlaceholderProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(XfMDCTextField), null);

        public string Text
        {
            get { return (string)base.GetValue(TextProperty); }
            set { base.SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create("TextColor", typeof(Color), typeof(XfMDCTextField), Color.Default);

        public Color TextColor
        {
            get { return (Color)base.GetValue(TextColorProperty); }
            set { base.SetValue(TextColorProperty, value); }
        }

    }
}