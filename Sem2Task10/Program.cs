﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()??"0");

if(num>99 && num<1000)
{
    Console.WriteLine($"Вторая цифра числа: {num/10%10}");
} else
{
    Console.WriteLine("Введенное число не трехзначное! Попробуйте еще.");
}

