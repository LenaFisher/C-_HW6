﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

String result = GetPointOfIntersection(k1, k2, b1, b2);
Console.WriteLine(result);

String GetPointOfIntersection(int a, int b, int c, int d)
{

    float x = (float)(d - c) / (a - b);
    float z = (float)(d - c) / (a - b);
    float y = (float)((a * z) + c);
    return "(" + x + "; " + y + ")";
}