using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy. What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine($"It's nice to have you {input}");
            Console.ReadKey();
        }
    }
}
