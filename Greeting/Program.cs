
using System;

namespace Submodule.Poc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, {Constants.Name}".ToUpper());

            Console.WriteLine("Press any key to exit.".ToUpper());
            Console.ReadKey();
        }
    }
}
