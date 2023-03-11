// ---------------------------------------------------------------------
// Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.
// ---------------------------------------------------------------------

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//output num->1 by Recursion
void LineGenRec(int num)
{
    Console.Write($" {num}");
    if(num > 1) LineGenRec(num - 1);
}

int num = ReadDataToInt("Enter a value: ");

LineGenRec(num);
Console.WriteLine();
