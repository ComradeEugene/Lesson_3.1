using System;

namespace Lesson_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int CheckValue = int.Parse(Console.ReadLine());

            if (CheckValue % 2 == 0)
            {
                Console.WriteLine($"{CheckValue} - четное число");
            }
            else
            {
                Console.WriteLine($"{CheckValue} - не четное число");
            }
            Console.ReadKey();
        }
    }
}
