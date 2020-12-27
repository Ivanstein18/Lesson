using System;

namespace DZ5
{
    class Program
    {
        static void Main(string[] args)
        {

            double ferstValue, secondValue;
            Console.WriteLine("Введите 1-е число");
            ferstValue = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите действие: + - / *");
            char znak = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2-е число");
            secondValue = double.Parse(Console.ReadLine());

            switch (znak)
            {
                case '+':
                    Console.WriteLine(ferstValue + secondValue);
                    break;
                case '-':
                    Console.WriteLine(ferstValue - secondValue);
                    break;
                case '/':
                    Console.WriteLine(ferstValue / secondValue);
                    break;
                case '*':
                    Console.WriteLine(ferstValue * secondValue);
                    break;
                default:
                    Console.WriteLine("Вы ввели не знакомый знак действия");
                    break;
            }

        }
    }
}
