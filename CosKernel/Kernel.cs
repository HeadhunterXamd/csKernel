using System;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace CosKernel
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully.");
        }

        protected override void Run()
        {
        }
    }
}
