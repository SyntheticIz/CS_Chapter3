using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay, lowrate = 5.65, highrate = 49.99;
            Console.Write("Enter pay rate: ");
            String scan = Console.ReadLine();
            pay = Convert.ToDouble(scan);
            if (pay < lowrate)
            {
                Console.WriteLine("Error pay too low!");
            }
            else if (pay > highrate)
            {
                Console.WriteLine("Error pay too high! Don't complain");
            }
        }
    }
}