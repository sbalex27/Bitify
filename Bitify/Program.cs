using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to convert to binary:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary: " + Convert.ToString(number, 2));
            Console.ReadLine();
        }
    }
}
