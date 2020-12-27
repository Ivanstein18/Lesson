using System;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int value = int.Parse(Console.ReadLine());

            int value2 = value % 2;

            if (value2 == 0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число не четное");

        }
    }
}
