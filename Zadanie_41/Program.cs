using System;

class Program
{
    static void Main()
    {
        int m = 0;
        bool isValidInput = false;

        // Валидация ввода количества чисел
        while (!isValidInput)
        {
            Console.Write("Введите количество чисел, которые вы хотите ввести: ");
            isValidInput = int.TryParse(Console.ReadLine(), out m);

            if (!isValidInput || m <= 0)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
                isValidInput = false;
            }
        }

        int count = 0; // Инициализируем счетчик чисел, больших нуля

        for (int i = 0; i < m; i++)
        {
            bool isNumberValid = false;
            int number = 0;

            // Валидация ввода числа
            while (!isNumberValid)
            {
                Console.Write("Введите число: ");
                isNumberValid = int.TryParse(Console.ReadLine(), out number);

                if (!isNumberValid)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                }
            }

            if (number > 0)
            {
                count++; // Если число больше нуля, увеличиваем счетчик на 1
            }
        }

        Console.WriteLine("Количество чисел, больших нуля: " + count); // Выводим количество чисел, больших нуля
    }
}
