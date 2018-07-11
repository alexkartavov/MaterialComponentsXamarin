using System;
using System.Collections.Generic;
using System.IO;

namespace PostSharpie
{
    public class SharpieParser
    {
        readonly string ApiDefinitionsFile = "ApiDefinitions.cs";
        readonly string StructsAndEnumsFile = "StructsAndEnums.cs";

        public SharpieParser()
        {
            _definitions = new List<IDefinition>();
            _usings = new List<string>();
        }

        #region Properties

        List<IDefinition> _definitions;
        public List<IDefinition> Definitions { get => _definitions; }

        List<string> _usings;
        public List<string> Usings { get => _usings; }

        #endregion //Properties


        #region Parse/Input Methods

        public void ParseInputFolder(string inputFolder)
        {
            if (string.IsNullOrEmpty(inputFolder))
                throw new ArgumentException("Input folder name must be specified.");

            if (!inputFolder.EndsWith('/'))
                inputFolder += '/';
            
            if (!File.Exists(inputFolder + ApiDefinitionsFile))
                throw new ArgumentException(inputFolder + ApiDefinitionsFile + " does not exist.");
            if (!File.Exists(inputFolder + StructsAndEnumsFile))
                throw new ArgumentException(inputFolder + StructsAndEnumsFile + " does not exist.");

            ParseDefinitions(inputFolder + ApiDefinitionsFile);
            ParseDefinitions(inputFolder + StructsAndEnumsFile);
        }

        void ParseDefinitions(string fileName)
        {
            using (var f = new StreamReader(fileName))
            {
                string line;
                List<string> meta = null;
                while ((line = f.ReadLine())!=null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;
                    
                    if(line.StartsWith("using ", StringComparison.Ordinal) && !Usings.Contains(line))
                    {
                        Usings.Add(line);
                    }
                    else if (line.StartsWith("// @", StringComparison.Ordinal))
                    {
                        var def = new ApiDefinition();
                        def.Lines.Add(line);
                        ReadDefinitionLines(f, def);
                        def.MetaLines = meta;
                        meta = null;

                        Definitions.Add(def);
                    }
                    else if (line.StartsWith("public enum ", StringComparison.Ordinal))
                    {
                        var def = new EnumDefinition();
                        def.Lines.Add(line);
                        ReadDefinitionLines(f, def);
                        def.MetaLines = meta;
                        meta = null;

                        Definitions.Add(def);
                    }
                    else if (line.StartsWith("static class ", StringComparison.Ordinal))
                    {
                        var def = new StructDefinition();
                        def.Lines.Add(line);
                        ReadDefinitionLines(f, def);
                        def.MetaLines = meta;
                        meta = null;

                        Definitions.Add(def);
                    }
                    else
                    {
                        if (meta == null)
                            meta = new List<string>();
                        meta.Add(line);
                    }
                }
            }
        }

        private void ReadDefinitionLines(StreamReader f, Definition def)
        {
            string line;
            while ((line = f.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                def.Lines.Add(line);
                if (line.Trim() == "}")
                    break;
            }
        }

        #endregion //Parse/Input Methods


        #region Output Methods

        public void WriteOutput(string fullName)
        {
            
        }

        #endregion //Output Methods
    }
}
