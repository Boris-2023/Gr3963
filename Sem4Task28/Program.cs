// Задача №28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

using System.Numerics;

//read the data into int
int ReadData(string msg)
{
    Console.Write(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

//output the result
void PrintAnswer(string explain, BigInteger num)
{
    Console.WriteLine(explain + num);
}

//method to compute the result
BigInteger FactSimple(int num)
{
    BigInteger sum = 1;
    for (int i=2; i<=num; i++)
    {
        sum*=i;
    }
    return sum;
}

int num = ReadData("Enter a value: ");
PrintAnswer("The factorial of the value: ", FactSimple(num));

