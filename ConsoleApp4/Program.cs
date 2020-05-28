using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start:

            Random randomNumber = new Random();

            int num1 = randomNumber.Next(1, 15);
            int num2 = randomNumber.Next(1, 10);
            int result = 0;
            Console.WriteLine("Type -1 to quit.");
            while (result != -1)
            {
                Console.Write("What is " + num1 + "*" + num2 + "= ");
                result = Convert.ToInt32(Console.ReadLine());

                
                if (result == num1 * num2)
                {
                    Console.WriteLine("You are correct!! ");
                }else if(result == -1)
                {
                    Console.WriteLine("Game Over!!");
                }
                else
                {
                    Console.WriteLine("You are wrong!! ");
                }
                 num1 = randomNumber.Next(1, 15);
                 num2 = randomNumber.Next(1, 10);

                Console.WriteLine();
            }


            Console.ReadKey();
            

            //goto Start;
        }
    }
}
