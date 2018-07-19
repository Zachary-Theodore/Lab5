using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Conti()
        {
            Console.WriteLine("Continue? (y/n)");
            string UserInput = Console.ReadLine();
            if (UserInput.ToLower() == "y")
            {
                Main();
            }
            else
            {
                return;
            }
        }
        static void Main()
        {
            Console.WriteLine("Input a Number to Calculate it's Factoral:");
            int userInput = int.Parse(Console.ReadLine());
            long result = 1;
            for (int i = 1; i <= userInput; i++)
            {
                
                result = result * i;
               // Console.WriteLine(result);

                
            }
            Console.WriteLine($"The factoral of {userInput} is {result}");
            Conti();
        }
    }
}
