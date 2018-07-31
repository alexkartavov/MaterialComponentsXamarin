using System;
using Xamarin.Forms;

namespace MaterialComponents.Forms
{
    public class XfMDCMultilineTextField: View
    {
        public XfMDCMultilineTextField()
        {
        }

        public static readonly BindableProperty ExpandsOnOverflowProperty =
            BindableProperty.Create("ExpandsOnOverflow", typeof(bool), typeof(XfMDCMultilineTextField), true);

        public bool ExpandsOnOverflow
        {
            get { return (bool)base.GetValue(ExpandsOnOverflowProperty); }
            set { base.SetValue(ExpandsOnOverflowProperty, value); }
        }

        public static readonly BindableProperty MinimumLinesProperty =
            BindableProperty.Create("MinimumLines", typeof(uint), typeof(XfMDCMultilineTextField), 1);

        public uint MinimumLines
        {
            get { return (uint)base.GetValue(MinimumLinesProperty); }
            set { base.SetValue(MinimumLinesProperty, value); }
        }

    }
}