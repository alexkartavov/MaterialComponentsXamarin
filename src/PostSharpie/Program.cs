using System;
using System.IO;
using CommandLineParser.Arguments;
using CommandLineParser.Exceptions;

namespace PostSharpie
{
    class Program
    {
        static readonly string DefaultInputFolder = ".";
        static readonly string DefaultOutputFolder = "./PostSharpieParsed";
        static readonly string DefaultNamespace = "MaterialComponents";
        static readonly string DefaultProject = "MaterialComponents";
        static readonly string DefaultConfigName = "MDCConfig.json";
        static readonly string DefaultXfFolder = "XamarinForms";
        static readonly string DefaultIOSFolder = "XamarinForms.iOS";
        static readonly string DefaultAndroidFolder = "XamarinForms.Android";

        static void Main(string[] args)
        {
            // process args
            CommandLineParser.CommandLineParser parser =
                                 new CommandLineParser.CommandLineParser();

            var helpArgument = new SwitchArgument(
                'h', "help", "Display usage help", false);
            var configArgument = new SwitchArgument(
                'c', "config", "Only generate config file.", false);
            var inputArgument = new DirectoryArgument(
                'i', "input", "Path to the input folder. The folder must contain ApiDefinitions.cs and StructsAndEnums.cs");
            var outputArgument = new DirectoryArgument(
                'o', "output", "Path to the output folder");
            outputArgument.DirectoryMustExist = false;
            var namespaceArgument = new ValueArgument<string>(
                'n', "namespace", "Namespace for the individual objects");

            parser.Arguments.Add(helpArgument);
            parser.Arguments.Add(configArgument);
            parser.Arguments.Add(inputArgument);
            parser.Arguments.Add(outputArgument);
            parser.Arguments.Add(namespaceArgument);
           
            try
            {
                parser.ParseCommandLine(args);

                if (helpArgument.Parsed && helpArgument.Value)
                {
                    parser.ShowUsage();
                    Console.WriteLine(@"First step is to generate a config file:
dotnet run -- -i ../Bindings/ -o ../MaterialComponents.Parsed/ -c

Second step is to edit the config file and set EnableBinding and EnableXFWrapper for desired components.

Third step is to generate separated ObjC wrappers and Xamarin Forms wrappers/renderers:
dotnet run -- -i ../Bindings/ -o ../MaterialComponents.Parsed/ -n MaterialComponents");
                }
            }
            catch (CommandLineException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            // load input files - ApiDefinitions.cs StructsAndEnums.cs
            var sharpieParser = new SharpieParser();
            var inputFolder = inputArgument.Parsed ? inputArgument.Value : new DirectoryInfo(DefaultInputFolder);

            try
            {
                sharpieParser.ParseInputFolder(inputFolder.FullName);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            // output each interface/delegate/enum into separate files, add usings, and namespace
            var outputFolder = outputArgument.Parsed ? outputArgument.Value : new DirectoryInfo(DefaultOutputFolder);
            var ns = namespaceArgument.Parsed ? namespaceArgument.Value : DefaultNamespace;
            var cfgOnly = configArgument.Parsed ? configArgument.Value : false;

            // Create or update JSON config file that lists all components we are interested in generating.
            sharpieParser.UpdateOrCreateConfig(outputFolder.FullName, DefaultConfigName);

            if (!cfgOnly)
            {
                // Using JSON config create bindings
                sharpieParser.WriteOutput(outputFolder.FullName + "/Components/", ns);
                sharpieParser.WriteProject(outputFolder.FullName + "/Components/", DefaultProject);

                // Using JSON config generates XF wrappers
                sharpieParser.WriteXFWrappers(outputFolder.FullName, 
                                              DefaultConfigName, 
                                              DefaultXfFolder, 
                                              DefaultIOSFolder, 
                                              DefaultAndroidFolder,
                                              DefaultNamespace);
            }

        }
    }
}
