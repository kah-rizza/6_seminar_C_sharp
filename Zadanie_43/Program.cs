﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения: ({x}; {y})");
    }
}
