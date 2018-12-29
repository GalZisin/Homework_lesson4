using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, ans = 0;
            Console.WriteLine("Enter the first number a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            while(i < b)
            {
                ans = ans + a;
                i++;
            }
            Console.WriteLine("The answer is: "+ans);
            Console.ReadLine();
        }
    }
}
