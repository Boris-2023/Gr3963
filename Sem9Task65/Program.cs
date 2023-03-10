//                                 Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

string LineGenRecRange(int m, int n)
{
    string res = string.Empty;
    if (m >= n)
    {
        res = " " + n.ToString();
    }
    else
    {
        res = res + " " + m + LineGenRecRange(m + 1, n);
    }
    return res;
}


int num1 = ReadDataToInt("Enter number to start : ");
int num2 = ReadDataToInt("Enter number to finish: ");

Console.WriteLine();

string numbers = num1 < num2 ? LineGenRecRange(num1, num2) : LineGenRecRange(num2, num1);
Console.WriteLine(numbers);

