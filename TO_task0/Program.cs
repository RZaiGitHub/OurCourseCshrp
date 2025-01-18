using System;

namespace TO_task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите значение A:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите значение B:");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите значение C:");
            //int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите три числа через пробел: ");

            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            if (numbers.Length != 3)
            {
                Console.WriteLine("Пожалуйста, введите три числа через пробел.");
            }
            else
            {
                if (int.TryParse(numbers[0], out int resultA) &&
                    int.TryParse(numbers[1], out int resultB) &&
                    int.TryParse(numbers[2], out int resultC))
                {
                    int a = resultA;
                    int b = resultB;
                    int c = resultC;

                    Console.WriteLine($"Вы ввели числа: A = {a}, B = {b}, C = {c}");

                    Console.WriteLine("Сумма:");
                    int res = 0;
                    res = a + b + c;
                    Console.WriteLine("Ответ: " + res);
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите только цифры.");
                }
            }

            Console.ReadKey();
        }
    }
}
