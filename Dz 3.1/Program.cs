using System;

namespace Dz_3._1
{
    class Program
    {
        // Дано натуральное число. Найти его наименьший делитель, отличный от 1.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please input natural number");
            int number;
             
            string text = Console.ReadLine();
            bool isTextParsed = int.TryParse(text, out number);
            if (!isTextParsed)
            {
                Console.WriteLine("Input was incorrect.");
            }
            else
            {   
                Console.WriteLine("List divider");

                for (int i = 2; i <= number; ++i)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
            Console.WriteLine("\nThe smallest divider is indicated at " +
                "\nthe beginning of the list of all divisors of the number.");
            Console.ReadKey();
        }
    }
}
