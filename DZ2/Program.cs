using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int c = a1 + a2 + a3;
            int d = a1 * a2 * a3;

            Console.WriteLine("Сумма чисел: " +c);
            Console.WriteLine("Произведение чисел: " + d);



        }
    }
}
