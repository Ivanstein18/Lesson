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
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            int colChet = 0, colNeChet = 0, sumChet = 0, sumNeChet = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    colChet++;
                    sumChet = sumChet + array[i];
                }
                else
                {
                    colNeChet++;
                    sumNeChet = sumNeChet + array[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Количество четных чисел:" + colChet);
            Console.WriteLine("Количество не четных чисел:" + colNeChet);
            Console.WriteLine("Сумма четных чисел:" + sumChet);
            Console.WriteLine("Сумма не четных чисел:" + sumNeChet);

        }
    }
}
