// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N > 1)
{
    for(int i=2; i<=N; i+=2) Console.Write(i + " ");
    Console.Write("\n");
} else Console.WriteLine("Введите число > 1!");

