using System;
namespace PostSharpie
{
    public class ApiDefinition: Definition
    {
        public ApiDefinition()
        {
        }

        public override void AddLine(string line)
        {
            base.AddLine(line);

            if (Lines.Count == 1 && line.StartsWith("interface ", StringComparison.Ordinal))
            {
                var ll = line.Split(' ');
                Name = ll[1];
            }
        }
    }
}
