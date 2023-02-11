// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число №1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Число №1 больше числа №2!");
} else if(num2 > num1)
{
    Console.WriteLine("Число №2 больше числа №1!");
} else
{
    Console.WriteLine("Числа №1 и №2 равны!");
}
