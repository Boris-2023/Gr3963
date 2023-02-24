// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//* Сделать оценку времени алгоритма через числа и строки

using System.Numerics;

//reads the data into string
string ReadDataStr(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

//output the result
void PrintAnswer(string explain, BigInteger num)
{
    Console.WriteLine(explain + num);
}

BigInteger SumOfDigitsByValue(BigInteger num)
{
    BigInteger sum = 0;

    while (num >= 1)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

int SumOfDigitsByString(string str)
{
    int sum = 0;

    int strLen = str.Length;

    for (int i = 0; i < strLen; i++)
    {
        sum += int.Parse($"{str[i]}");
    }

    return sum;
}


string numStr = ReadDataStr("Enter a value to know the sum of its digits: ");//takes the value as a string

//estimates time of process by Value
DateTime t1Start = DateTime.Now;//fixes start time
BigInteger numInt = BigInteger.Parse(numStr ?? "0");//converts into BigInteger - for extreme big values
PrintAnswer($"Sum of digits by Value is: ", SumOfDigitsByValue(numInt));//processes as BigInteger
DateTime t1End = DateTime.Now;//fixes end time of process by Value

//estimates time of process by String
DateTime t2Start = DateTime.Now;//fixes start time
PrintAnswer($"Sum of digits by String is: ", SumOfDigitsByString(numStr ?? "0"));//processes as a String
DateTime t2End = DateTime.Now; ;//fixes end time of process by String
//TimeSpan tElapsed = DateTime.Now - t2Start;

Console.WriteLine();
Console.WriteLine($"Time elapsed:\nby Value: \t{t1End - t1Start}\nby String:\t{t2End - t2Start}");//output elapsed times into console

