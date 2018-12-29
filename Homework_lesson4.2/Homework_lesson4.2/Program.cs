using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0;
            double avg = 0;
            Console.WriteLine("Sum of 2 numbers and their avarage");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Enter the first numer");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second numer");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            avg = sum / 2.0;

            Console.WriteLine("The sum is: "+sum);
            Console.WriteLine("The avg is: " + avg);
            Console.ReadLine();
        }
        
    }
}
