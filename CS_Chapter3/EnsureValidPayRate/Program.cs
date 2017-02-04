using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay, lowrate = 5.65, highrate = 49.99;
            Console.Write("Enter pay rate: ");
            String scan = Console.ReadLine();
            pay = Convert.ToDouble(scan);
            double wpay = pay * 40;
            if (pay < lowrate || pay > highrate)
            {
                Console.WriteLine("Enter your actual pay you idiot.");
                scan = Console.ReadLine();
                pay = Convert.ToDouble(scan);
                Console.Write("Your weekly pay should be: " + wpay);
            }
            else
            {
                Console.Write("Your weekly pay should be: " + wpay);
            }
        }
    }
}
