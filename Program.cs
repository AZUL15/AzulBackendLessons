using System;

namespace TAZASTICH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            var Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Number % 2) == 0);
            Console.ReadKey();
        }
    }
}