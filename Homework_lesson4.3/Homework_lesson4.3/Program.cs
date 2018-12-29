using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson4._3
{
    class Program
    {
        static void Main(string[] args)
        {
         int x, sum = 0; ; 
         
         Console.WriteLine("Enter numbers and sum all until negative number is entered");
         Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enter anumber: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 0 || x == 0)
            {
                sum = x;
            }
            while (x > 0||x== 0){
            Console.WriteLine("Enter anumber: ");
            x = Convert.ToInt32(Console.ReadLine());
                if(x > 0)
                {
                    sum = sum + x;
                }
           
         }
         Console.WriteLine("The sum of the numbers is: " + sum);
         Console.ReadLine();
        }


    }
}
