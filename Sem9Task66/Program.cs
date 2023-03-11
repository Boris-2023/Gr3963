// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

// computes the sum of natural values in a range [m -> n]
int SumRecRange(int m, int n)
{
    if (m == n)//stop recursion
    {
        return n;
    }
    else
    {
        return m + SumRecRange(m + 1, n);
    }
}

//output the result
void PrintAnswer(string explain, int num)
{
    Console.WriteLine("\n" + explain + num);
}


int num1 = ReadDataToInt("Enter number to start : ");
int num2 = ReadDataToInt("Enter number to finish: ");

int sum = num1 < num2 ? SumRecRange(num1, num2) : SumRecRange(num2, num1);
PrintAnswer("The sum is: ", sum);

