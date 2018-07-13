using System;
using System.Collections.Generic;

namespace PostSharpie
{
    public abstract class Definition: IDefinition
    {
        protected Definition()
        {
            _lines = new List<string>();
        }

        List<string> _lines;
        public List<string> Lines { get => _lines; }

        public List<string> MetaLines { get; set; }

        public string Name { get; protected set; }

        public virtual void AddLine(string line)
        {
            Lines.Add(line);
        }
    }
}
