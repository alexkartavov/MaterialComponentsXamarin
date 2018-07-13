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

        static void Main(string[] args)
        {
            // process args
            CommandLineParser.CommandLineParser parser =
                                 new CommandLineParser.CommandLineParser();

            var helpArgument = new SwitchArgument(
                'h', "help", "Display usage help", false);
            var inputArgument = new DirectoryArgument(
                'i', "input", "Path to the input folder. The folder must contain ApiDefinitions.cs and StructsAndEnums.cs");
            var outputArgument = new DirectoryArgument(
                'o', "output", "Path to the output folder");
            outputArgument.DirectoryMustExist = false;
            var namespaceArgument = new ValueArgument<string>(
                'n', "namespace", "Namespace for the individual objects");

            parser.Arguments.Add(helpArgument);
            parser.Arguments.Add(inputArgument);
            parser.Arguments.Add(outputArgument);
            parser.Arguments.Add(namespaceArgument);
           
            try
            {
                parser.ParseCommandLine(args);

                if (helpArgument.Parsed && helpArgument.Value)
                {
                    parser.ShowUsage();
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

            sharpieParser.WriteOutput(outputFolder.FullName, ns);
            sharpieParser.WriteProject(outputFolder.FullName, "MaterialComponents");

            // generate JSON config file for each objects
            // MDCControl: {
            //   GenerateXamarinFormsWrapper: boolean - to indicate that a wrapper needs to be created
            //   BindableProperties: { - to list properties that are bindable and to generate renderers that copy values from Element to Control
            //      list of properties
            //   }
            //   Events: {
            //      list of events to propagate between renderer's Element and Control
            //   }
            // }
            // This config to be used during second stage that generates XF wrappers
            //}
        }
    }
}
