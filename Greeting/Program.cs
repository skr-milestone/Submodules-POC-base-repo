
using System;

namespace Submodule.Poc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"HELLO, {Constants.Name}");

            Console.WriteLine("Press any key to exit.".ToUpper());
            Console.ReadKey();
        }
    }
}
