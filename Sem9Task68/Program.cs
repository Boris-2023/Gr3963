// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

// computes the output of Akkerman function for args m & n
long AkkermanRec(long m, long n)
{
    if (m == 0)//stop recursion
        return (n + 1);
    else
      if ((m != 0) && (n == 0))
        return AkkermanRec(m - 1, 1);
    else
        return AkkermanRec(m - 1, AkkermanRec(m, n - 1));
}

long num1 = (long) ReadDataToInt("Enter value #1 (m): ");
long num2 = (long) ReadDataToInt("Enter value #2 (n): ");

Console.WriteLine($"\nA({num1},{num2}) = {AkkermanRec(num1, num2)}");

