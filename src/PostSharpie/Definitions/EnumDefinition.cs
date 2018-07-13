using System;
namespace PostSharpie
{
    public class EnumDefinition: Definition
    {
        public EnumDefinition()
        {
        }

        public override void AddLine(string line)
        {
            if (Lines.Count == 0 && line.StartsWith("public enum ", StringComparison.Ordinal))
            {
                var ll = line.Split(' ');
                Name = ll[2];

                if (line.EndsWith(": nint", StringComparison.Ordinal))
                {
                    line = line.Substring(0, line.Length - 6) + ": long";
                }
                else if (line.EndsWith(": nuint", StringComparison.Ordinal))
                {
                    line = line.Substring(0, line.Length - 7) + ": ulong";
                }
            }
            base.AddLine(line);
        }
    }
}
