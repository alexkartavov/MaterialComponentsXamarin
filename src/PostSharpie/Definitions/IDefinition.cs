using System;
using System.Collections.Generic;

namespace PostSharpie
{
    public interface IDefinition
    {
        List<string> Lines { get; }
    }
}
