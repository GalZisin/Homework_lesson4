using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = 128;
            Console.WriteLine("Ener your guess: ");
            int guess= Convert.ToInt32(Console.ReadLine());
            while (guess != secret)
            {
                if (guess > secret)
                {
                    Console.WriteLine("Too big");
                    Console.WriteLine("Ener your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Too small");
                    Console.WriteLine("Ener your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine("BINGO!");
            Console.ReadLine();
        }
    }
}
