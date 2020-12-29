using System;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int fertValue, secondValue, arrayNumber;

            Console.WriteLine("Введите с какого числа начать считать");

            fertValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите до какого числа считать");

            secondValue = int.Parse(Console.ReadLine());

            arrayNumber = secondValue - (fertValue - 1);

            int[] array = new int[arrayNumber];

            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            



        }
    }
}
