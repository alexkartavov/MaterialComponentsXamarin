using System;
using System.Collections.Generic;

namespace PostSharpie
{
    public class Binding
    {
        public Binding()
        {
        }

        public string Name { get; set; }
        public bool EnableBinding { get; set; }

        public bool EnableXFWrapper { get; set; }
        public List<BindableProperty> BindableProperties { get; set; }
        public List<PropagatingEvent> Events { get; set; }
    }
}
