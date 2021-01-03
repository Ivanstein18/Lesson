using System;

namespace DZ8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int largeArray = int.Parse(Console.ReadLine());

            int[] aray = new int[largeArray];

            for (int i = 0; i < aray.Length; i++)
            {
                Console.Write($"Введите элеиент массива с индексом {i}: ");

                aray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < aray.Length; i++)
            {
                Console.WriteLine(aray[i]);
            }


            for (int i = 0; i < aray.Length; i++)
            {
                for (int j = i+1; j < aray.Length; j++)
                {
                    
                    if (aray[j]<aray[i])
                    {
                        int temp = 0;
                        temp = aray[i];
                        aray[i] = aray[j];
                        aray[j] = temp;
                    }
                }

            }

            Console.WriteLine("Ввывод нового массива: ");
            for (int i = 0; i < aray.Length; i++)
            {
                Console.WriteLine(aray[i]);
            }

            Console.Write("Наименьший элемент массива: "+ aray[0]);



        }
    }
}
