using System;

namespace TAZASTICH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First solution using if statement
            CheckEvenOrOddWithIf();

            // Second solution using switch statement
            CheckEvenOrOddWithSwitch();
        }

        /// <summary>
        /// Checks if a number is even or odd using an if statement.
        /// </summary>
        private static void CheckEvenOrOddWithIf()
        {
            Console.WriteLine("Write a number:");
            var number = Convert.ToInt32(Console.ReadLine());

            if ((number % 2) == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            // Wait for user to press a key before closing
            Console.ReadKey();
        }

        /// <summary>
        /// Checks if a number is even or odd using a switch statement.
        /// </summary>
        private static void CheckEvenOrOddWithSwitch()
        {
            Console.WriteLine("Write a number:");
            var number = Convert.ToInt32(Console.ReadLine());

            // Switch based on the remainder of division by 2
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("The number is even.");
                    break;
                default:
                    Console.WriteLine("The number is odd.");
                    break;
            }

            // Wait for user to press a key before closing
            Console.ReadKey();
        }
    }
}
