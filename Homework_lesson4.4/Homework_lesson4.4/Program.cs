using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 2;
            Console.WriteLine("Check if the numer is primery or not");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            while(a % m!=0 && m < a)
            {
                m++;
            }
            if (m==a)
            {
                Console.WriteLine("The number is primery");
            }
                
            else
            {
                Console.WriteLine("The numer isn't primery");
            }
            Console.ReadLine();
        }
    }
}
