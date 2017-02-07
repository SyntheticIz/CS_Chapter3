using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            double gpa;
            String scan;
            Console.Write("What's your gpa: ");
            scan = Console.ReadLine();
            gpa = Convert.ToDouble(scan);
            Console.Write("What's what was your score on the admission test: ");
            scan = Console.ReadLine();
            score = Convert.ToInt32(scan);

            if (gpa >= 3.0 && score >= 60)
            {
                Console.WriteLine("Accepted");
            }
            else if (gpa < 3.0 && score >= 80)
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Reject");
            }
        }
    }
}
