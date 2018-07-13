using System;
namespace PostSharpie
{
    public class StructDefinition: Definition
    {
        public StructDefinition()
        {
        }

        public override void AddLine(string line)
        {
            base.AddLine(line);

            if (Lines.Count == 1 && line.StartsWith("static class ", StringComparison.Ordinal))
            {
                var ll = line.Split(' ');
                Name = ll[2];
            }
        }
    }
}
