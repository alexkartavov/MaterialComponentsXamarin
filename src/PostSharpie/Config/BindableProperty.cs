using System;
namespace PostSharpie
{
    public class BindableProperty
    {
        public BindableProperty()
        {
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string DefaultValue { get; set; }
    }
}
