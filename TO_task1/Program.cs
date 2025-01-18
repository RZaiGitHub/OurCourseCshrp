namespace TO_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------V-1------------");

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
                    double x = resultA;
                    double y = resultB;
                    double a = resultC;

                 

                    Console.WriteLine($"Вы ввели числа: A = {x}, B = {y}, C = {a}");

                    double z = 0;
                    z = ((3 + x / y) / (2 * a / x)) - ((3 * x * a + 2 * a + a * y) / (3 * a + 2 * x - y)) + 10 * y * a;


                    Console.WriteLine(" V-1 Ответ: " + z);

                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите только цифры.");
                }
            }


            Console.WriteLine("-----------V-2------------");

            Console.Write("Введите три числа через пробел: ");

            string input2 = Console.ReadLine();
            string[] numbers2 = input2.Split(' ');

            if (numbers2.Length != 3)
            {
                Console.WriteLine("Пожалуйста, введите три числа через пробел.");
            }
            else
            {
                if (int.TryParse(numbers2[0], out int resultA2) &&
                    int.TryParse(numbers2[1], out int resultB2) &&
                    int.TryParse(numbers2[2], out int resultC2))
                {
                   

                    double x1 = resultA2;
                    double y1 = resultB2;
                    double a1 = resultC2;

                    Console.WriteLine($"Вы ввели числа: A = {x1}, B = {y1}, C = {a1}");


                    double z1 = 0;
                    z1 = 3 * x1 + ((3 * x1 + y1 - 4 * a1) / (a1 + 2 * x1 + 7 * y1)) + 5 + ((a1 / y1 + 1) / (2 * a1 / x1));


                    Console.WriteLine(" V-2 Ответ: " + z1);
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
