using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours;
            double pay, week, tax;
            String scan;
            Console.Write("Hourly pay: ");
            scan = Console.ReadLine();
            pay = Convert.ToDouble(scan);
            Console.Write("Hours worked: ");
            scan = Console.ReadLine();
            hours = Convert.ToInt32(scan);
            week = hours * pay;
            if (week > 300)
            {
                tax = week - (week * .12);
                Console.Write("Your pay this week before taxes will be: " + week + "\nAfter taxes it will be: " + tax);
            }
            else
            {
                tax = week - (week * .10);
                Console.Write("Your pay this week before taxes will be: " + week + "\nAfter taxes it will be: " + tax);
            }
        }
    }
}
