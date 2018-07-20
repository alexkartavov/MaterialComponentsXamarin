using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

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
                while ((line = f.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    if (line.StartsWith("using ", StringComparison.Ordinal))
                    {
                        if (!Usings.Contains(line))
                            Usings.Add(line);
                    }
                    else if (line.StartsWith("interface ", StringComparison.Ordinal))
                    {
                        var def = new ApiDefinition();
                        def.AddLine(line);
                        ReadDefinitionLines(f, def);
                        def.MetaLines = meta;
                        meta = null;

                        Definitions.Add(def);
                    }
                    else if (line.StartsWith("public enum ", StringComparison.Ordinal))
                    {
                        var def = new EnumDefinition();
                        def.AddLine(line);
                        ReadDefinitionLines(f, def);
                        def.MetaLines = meta;
                        meta = null;

                        Definitions.Add(def);
                    }
                    else if (line.StartsWith("static class ", StringComparison.Ordinal))
                    {
                        var def = new StructDefinition();
                        def.AddLine(line);
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

        public void WriteOutput(string outputFolder, string ns)
        {
            var dir = new DirectoryInfo(outputFolder);
            dir.Create();

            foreach (var def in Definitions)
            {
                WriteDefinition(outputFolder, ns, def);
            }
        }

        private void WriteDefinition(string outputFolder, string ns, IDefinition def)
        {
            if (!string.IsNullOrEmpty(def.Name) && def.Active)
            {
                if (!outputFolder.EndsWith('/'))
                    outputFolder += '/';

                Console.WriteLine("Writing file: {0}", outputFolder + def.Name + ".cs");
                if (File.Exists(outputFolder + def.Name + ".cs"))
                {
                    var c = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Already exists");
                    Console.ForegroundColor = c;
                    return;
                }

                using (var streamWriter = new StreamWriter(outputFolder + def.Name + ".cs"))
                {

                    WriteUsings(streamWriter);
                    WriteGap(streamWriter);
                    WriteNamespaceBegins(streamWriter, ns);
                    WriteLines(streamWriter, def.MetaLines);
                    WriteLines(streamWriter, def.Lines);
                    WriteNamespaceEnds(streamWriter);
                }
            }
        }

        private void WriteGap(StreamWriter streamWriter)
        {
            streamWriter.WriteLine();
        }

        private void WriteUsings(StreamWriter streamWriter)
        {
            foreach (var line in Usings)
                streamWriter.WriteLine(line);
        }

        private void WriteNamespaceBegins(StreamWriter streamWriter, string ns)
        {
            streamWriter.WriteLine("namespace " + ns);
            streamWriter.WriteLine("{");
        }

        private void WriteNamespaceEnds(StreamWriter streamWriter)
        {
            streamWriter.WriteLine("}");
        }

        private void WriteLines(StreamWriter streamWriter, List<string> lines)
        {
            if (lines == null)
                return;

            foreach (var line in lines)
            {
                streamWriter.WriteLine("\t" + line);
            }
        }

        #endregion //Output Methods

        #region Output Project

        readonly string _bindingApiDef = @"<ObjcBindingApiDefinition Include=""{0}"" />";
        readonly string _bindingCoreTmpl = @"<ObjcBindingCoreSource Include=""{0}"" />";
        readonly string _projectTmpl = @"<Project DefaultTargets=""Build"" ToolsVersion=""4.0"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>{F888B10B-1D2E-44F5-AAE9-3335566E67A7}</ProjectGuid>
    <ProjectTypeGuids>{8FFB629D-F513-41CE-95D2-7ECE97B6EEEC};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <RootNamespace>MaterialComponents</RootNamespace>
    <AssemblyName>MaterialComponents</AssemblyName>
    <IPhoneResourcePrefix>Resources</IPhoneResourcePrefix>
    <ReleaseVersion>39.0.0</ReleaseVersion>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug</OutputPath>
    <DefineConstants>DEBUG;</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">
    <Optimize>true</Optimize>
    <OutputPath>bin\Release</OutputPath>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <DocumentationFile></DocumentationFile>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <NoWarn>CS0108;CS0114;MSB9004</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include=""System"" />
    <Reference Include=""Xamarin.iOS"" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include=""Properties\AssemblyInfo.cs"" />
  </ItemGroup>
  <ItemGroup>
{0}
  </ItemGroup>
  <ItemGroup>
{1}
  </ItemGroup>
  <ItemGroup>
    <NativeReference Include=""..\..\references.55\MDFTextAccessibility.framework"">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include=""..\..\references.55\MotionAnimator.framework"">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include=""..\..\references.55\MotionInterchange.framework"">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include=""..\..\references.55\MotionTransitioning.framework"">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include=""..\..\references.55\MaterialComponents.framework"">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include=""..\..\references\MDFInternationalization.framework"">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
  </ItemGroup>
  <Import Project=""$(MSBuildExtensionsPath)\Xamarin\iOS\Xamarin.iOS.ObjCBinding.CSharp.targets"" />
</Project>";

        public void WriteProject(string outputFolder, string projName)
        {
            var dir = new DirectoryInfo(outputFolder);
            dir.Create();

            var bindingsApiDef = new StringBuilder();
            var bindingsCoreDef = new StringBuilder();

            foreach (var def in Definitions.Where(d => !string.IsNullOrEmpty(d.Name) && d.Active))
            {
                if (def is ApiDefinition)
                {
                    bindingsApiDef.AppendLine("\t" + string.Format(_bindingApiDef, def.Name + ".cs"));
                }
                else if (def is EnumDefinition || def is StructDefinition)
                {
                    bindingsCoreDef.AppendLine("\t" + string.Format(_bindingCoreTmpl, def.Name + ".cs")); ;
                }
            }

            using (var f = new StreamWriter(dir.FullName + "/" + projName + ".csproj"))
            {
                f.Write(_projectTmpl
                        .Replace("{0}", bindingsApiDef.ToString())
                        .Replace("{1}", bindingsCoreDef.ToString()));
            }
        }

        #endregion //Output Project

        #region JSON config

        // MDCControl: {
        //   Biding: boolean - to indicate whether this binding needs to be generated.
        //   XFormsWrapper: boolean - to indicate that a wrapper needs to be created. Only a subset of bindings will get that.
        //   BindableProperties: { - to list properties that are bindable and to generate renderers that copy values from Element to Control
        //      list of properties
        //   }
        //   Events: {
        //      list of events to propagate between renderer's Element and Control
        //   }
        // }
        internal void UpdateOrCreateConfig(string outputFolder, string configFile)
        {
            var dir = new DirectoryInfo(outputFolder);
            dir.Create();

            List<Binding> bindings = (File.Exists(dir.FullName + "/" + configFile)
                                      ? JsonConvert.DeserializeObject<List<Binding>>(File.ReadAllText(dir.FullName + "/" + configFile))
                                      : new List<Binding>());

            foreach (var def in Definitions.Where(d => !string.IsNullOrEmpty(d.Name)))
            {
                var binding = bindings.FirstOrDefault(b => b.Name == def.Name);
                if (binding == null)
                {
                    binding = new Binding()
                    {
                        Name = def.Name,
                        EnableBinding = def.Active,
                        EnableXFWrapper = false
                    };

                    bindings.Add(binding);
                }
                else
                {
                    def.Active = binding.EnableBinding;
                }
            }

            File.WriteAllText(dir.FullName + "/" + configFile, JsonConvert.SerializeObject(bindings, Formatting.Indented));
        }

        #endregion //JSON config

        #region Xamarin Forms wrappers

        internal void WriteXFWrappers(string fullName, string defaultConfigName)
        {
            
        }

        #endregion //Xamarin Forms Wrappers
    }
}
