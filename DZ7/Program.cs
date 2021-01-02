using System;

namespace DZ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int largMassive = int.Parse(Console.ReadLine());

            int[] massive = new int[largMassive];

            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"Введите элемент массива с индексом {i}: ");
                massive[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }

            int[] mixMassive = new int[largMassive];

            for (int i = 0, j = (mixMassive.Length-1); i < massive.Length; i++, j--)
            {
                mixMassive[j] = massive[i];
            }

            Console.WriteLine("Вывод массива наоборот:");
            for (int i = 0; i < mixMassive.Length; i++)
            {
                Console.WriteLine(mixMassive[i]);
            }

        }
    }
}
