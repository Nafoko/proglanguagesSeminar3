// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// using System;
// using Internal;

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int len = Length(num);
Console.WriteLine($"Сумма цифр в числе {num} = {Sum(num, len)}");

// 1. Определить количество символов в цифре
int Length(int num)
{
    int index = 0;
    while (num > 0)
    {
        num = num / 10;
        index++;
    }
    return index;
}

int Sum(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
