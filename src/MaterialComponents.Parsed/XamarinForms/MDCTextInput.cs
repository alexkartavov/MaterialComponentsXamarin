using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCTextInput: View
    {
        public XfMDCTextInput()
        {
        }

        public static readonly BindableProperty CursorColorProperty =
            BindableProperty.Create("CursorColor", typeof(Color), typeof(XfMDCTextInput), Color.Default);

        public Color CursorColor
        {
            get { return (Color)base.GetValue(CursorColorProperty); }
            set { base.SetValue(CursorColorProperty, value); }
        }

        public static readonly BindableProperty EnabledProperty =
            BindableProperty.Create("Enabled", typeof(bool), typeof(XfMDCTextInput), true);

        public bool Enabled
        {
            get { return (bool)base.GetValue(EnabledProperty); }
            set { base.SetValue(EnabledProperty, value); }
        }

        public static readonly BindableProperty HidesPlaceholderOnInputProperty =
            BindableProperty.Create("HidesPlaceholderOnInput", typeof(bool), typeof(XfMDCTextInput), true);

        public bool HidesPlaceholderOnInput
        {
            get { return (bool)base.GetValue(HidesPlaceholderOnInputProperty); }
            set { base.SetValue(HidesPlaceholderOnInputProperty, value); }
        }

        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create("Placeholder", typeof(string), typeof(XfMDCTextInput), null);

        public string Placeholder
        {
            get { return (string)base.GetValue(PlaceholderProperty); }
            set { base.SetValue(PlaceholderProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(XfMDCTextInput), null);

        public string Text
        {
            get { return (string)base.GetValue(TextProperty); }
            set { base.SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create("TextColor", typeof(Color), typeof(XfMDCTextInput), Color.Default);

        public Color TextColor
        {
            get { return (Color)base.GetValue(TextColorProperty); }
            set { base.SetValue(TextColorProperty, value); }
        }

    }
}