using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay, lowrate = 5.65;
            Console.WriteLine("Enter pay rate: ");
            String scan = Console.ReadLine();
            pay = Convert.ToDouble(scan);
            if (pay < lowrate)
            {
                Console.WriteLine("Error pay too low!");
            }
        }
    }
}
