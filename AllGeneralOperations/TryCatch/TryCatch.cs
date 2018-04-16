using System;

namespace TryCatch
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            int age = 0;
            while (true)
            {
                Console.WriteLine("Write your age:");
                try
                {
                    age = int.Parse(Console.ReadLine());
                    break;

                }
                catch (Exception)
                {
                    Console.WriteLine("Give me an integer number!");

                }
            }

            age++;
            Console.WriteLine($"You will be {age} years old!");
        }
    }
}
