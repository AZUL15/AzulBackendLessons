using System;
using TAZASTICH.Utils;

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





// OTRA POSIBLE SOLUCION ,TAKVEZ MAS COMPLEJA PERO CREO QUE SIRVE 

// Console.WriteLine("Write a number");
//var Number = Convert.ToInt32(Console.ReadLine());

//if ((Number % 2) == 0)
//{
//  Console.WriteLine("The number is even.")
//}
//else
//{
//  Console.WriteLine("The number is odd.");
//}

//Console.ReadKey();
//}

// OTRA POSIBLE SOLUCION USANDO SWITCH

//Console.WriteLine("Write a number");
//var Number = Convert.ToInt32(Console.ReadLine());

//switch (Number % 2)
//{
//case 0:
//Console.WriteLine("The number is even.");
//break;
//default:
//Console.WriteLine("The number is odd.");

//}
//Console.ReadKey();

