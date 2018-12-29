using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int azeret = 1, i = 1;
            Console.WriteLine("Enter a number for azeret culculaion");
            int a = Convert.ToInt32(Console.ReadLine());
            while (i < a|| i==a)
            {
                azeret = azeret * i;
                i++;
            }
            Console.WriteLine("The result is :"+azeret);
            Console.ReadLine();
        }
    }
}
