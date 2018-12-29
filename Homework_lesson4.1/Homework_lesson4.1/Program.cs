using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Is a divide by b?");

            Console.WriteLine("Enter a first number");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");

            b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("a divide by b ");
            }
            else
            {
                Console.WriteLine("a isn't divide by b ");
            }

            Console.ReadLine();
        }
    }
}
