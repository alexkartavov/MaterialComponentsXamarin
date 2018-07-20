using System;
using System.Collections.Generic;

namespace PostSharpie
{
    public interface IDefinition
    {
        List<string> Lines { get; }
        List<string> MetaLines { get; set; }
        string Name { get; }
        bool Active { get; set; }
    }
}
