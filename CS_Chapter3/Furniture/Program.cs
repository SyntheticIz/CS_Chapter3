using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = 100, O = 225, M = 350;
            Console.WriteLine("Place your order for a table:\nPine Costs $" + P + "\nOak Costs $" + O + "\nMahogany Costs $" + M);
            String scan = Console.ReadLine();
            string table = scan;
            if (table.ToLower().StartsWith("p"))
            {
                Console.WriteLine("Your table costs: $" + P);
            }
            else if (table.ToLower().StartsWith("o"))
            {
                Console.WriteLine("Your table costs: $" + O);
            }
            else if (table.ToLower().StartsWith("m"))
            {
                Console.WriteLine("Your table costs: $" + M);
            }
            else
            {
                Console.WriteLine("Your table costs: $0");
            }
        }
    }
}
