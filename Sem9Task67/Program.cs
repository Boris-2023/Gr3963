// ---------------------------------------------------------------------
//                                 Задача 67
// принимает на вход число и возвращает сумму цифр числа
// ---------------------------------------------------------------------

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

int RecSumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + RecSumDigits(num / 10);
}


int num = ReadDataToInt("Enter a number to compute the number of its digits: ");

Console.WriteLine();
Console.WriteLine(RecSumDigits(num));

