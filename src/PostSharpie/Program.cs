using System;

namespace PostSharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            // process args

            // load input files - ApiDefinitions.cs StructsAndEnums.cs

            // output each interface/delegate/enum into separate files, add usings, and namespace

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
