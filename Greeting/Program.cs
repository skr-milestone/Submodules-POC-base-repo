
using System;

namespace Submodule.Poc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, {Constants.Name}!");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
