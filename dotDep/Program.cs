using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace dotDep
{
    class Program
    {
        static void Main(string[] args)
        {
            var slnName = args.First();

            if (!File.Exists(slnName))
            {
                throw new FileNotFoundException($"File {slnName} not found.");
            }

            Solution solution = MSBuildWorkspace.Create()
                .OpenSolutionAsync(slnName)
                .Result;

            //Console.WriteLine(solution.ToString());
        }
    }
}
