// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//output numStart -> numFinish by Recursion
void LineGenRec(int numStart, int numFinish)
{
    if (numStart >= numFinish)//stop recursion
        Console.Write(numStart);
    else
    {
        Console.Write($"{numStart}, ");
        LineGenRec(numStart+1, numFinish);
    }
}

int num = ReadDataToInt("Enter a value: ");

LineGenRec(1, num);
Console.WriteLine();
