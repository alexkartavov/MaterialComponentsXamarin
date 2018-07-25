using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PostSharpie
{
    public class Binding
    {
        public Binding()
        {
        }

        public string Name { get; set; }
        public bool EnableBinding { get; set; } = false;

        public bool EnableXFWrapper { get; set; } = false;
        public List<BindableProperty> BindableProperties { get; set; } = new List<BindableProperty>();
        public List<PropagatingEvent> Events { get; set; } = new List<PropagatingEvent>();

        private readonly string XfWrapperTemplate = @"using System;
using Xamarin.Forms;

namespace {0}.Forms
{
    public class Xf{1}: View
    {
        public Xf{1}()
        {
        }
{2}
    }
}";

        private readonly string BindablePropertyTemplate = @"
        public static readonly BindableProperty {0}Property =
            BindableProperty.Create(""{0}"", typeof({1}), typeof(Xf{2}), {3});

        public {1} {0}
        {
            get { return ({1})base.GetValue({0}Property); }
            set { base.SetValue({0}Property, value); }
        }";

        private readonly string IosRendererTemplate = @"using System;
using System.ComponentModel;
using System.Drawing;
using {0};
using {0}.Forms;
using {0}.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(Xf{1}), typeof({1}Renderer))]

namespace {0}.iOS
{
    public class {1}Renderer : ViewRenderer<Xf{1}, {1}>
    {
        public {1}Renderer()
        {
        }

        protected override {1} CreateNativeControl()
        {
            return new {1}();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xf{1}> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(CreateNativeControl());
                }
{2}
            }

            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
{3}
        }
{4}
    }
}";
        private readonly string IosUpdateTemplate = @"
                Update{0}();";
        private readonly string IosPropertyChangedTemplate = @"if (e.PropertyName == Xf{0}.{1}Property.PropertyName)
            {
                Update{1}();
            }
            ";
        private readonly string IosUpdateMethodTemplate = @"
        void Update{0}()
        {
        }";

        //private readonly string AndroidRendererTemplate = @"";

        public void GenerateXfWrapperWithBindableProperties(string xfFolder, string ns)
        {
            if (BindableProperties == null)
                return;
            
            var content = new StringBuilder();
            var properties = new StringBuilder();

            foreach(var property in BindableProperties)
            {
                properties.AppendLine(BindablePropertyTemplate
                                  .Replace("{0}", property.Name)
                                  .Replace("{1}", property.Type)
                                  .Replace("{2}", Name)
                                  .Replace("{3}", property.DefaultValue));
            }

            content.Append(XfWrapperTemplate
                           .Replace("{0}", ns)
                           .Replace("{1}", Name)
                           .Replace("{2}", properties.ToString()));

            File.WriteAllText(xfFolder + "/" + Name + ".cs", content.ToString());
        }

        public void GenerateIOSRenderer(string iosFolder, string ns)
        {
            if (BindableProperties == null)
                return;
            
            var content = new StringBuilder();
            var updates = new StringBuilder();
            var props = new StringBuilder();
            var methods = new StringBuilder();

            foreach (var property in BindableProperties)
            {
                updates.Append(IosUpdateTemplate
                                  .Replace("{0}", property.Name));

                if (props.Length == 0)
                {
                    props.AppendLine();
                    props.Append(@"            ");
                }
                else
                    props.Append("else ");
                props.Append(IosPropertyChangedTemplate
                             .Replace("{0}", Name)
                             .Replace("{1}", property.Name));
                
                methods.Append(IosUpdateMethodTemplate
                                  .Replace("{0}", property.Name));
            }

            content.Append(IosRendererTemplate
                           .Replace("{0}", ns)
                           .Replace("{1}", Name)
                           .Replace("{2}", updates.ToString())
                           .Replace("{3}", props.ToString())
                           .Replace("{4}", methods.ToString()));

            File.WriteAllText(iosFolder + "/" + Name + ".cs", content.ToString());
        }

        public void GenerateAndroidRenderer(string androidFolder, string ns)
        {
            if (BindableProperties == null)
                return;
            

        }
    }
}
