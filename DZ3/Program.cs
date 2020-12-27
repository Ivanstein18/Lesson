using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество реблей");
            int rub = int.Parse(Console.ReadLine());
            double s = rub * 73.69;
            Console.WriteLine(s);

        }
    }
}
