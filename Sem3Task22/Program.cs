// Задача №22
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//выводятся в строку числа, а под ними - квадраты

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

string LineBuilder(int num, int pw)
{
    string res = String.Empty;

    for(int i=1; i<=num; i++)
    {
        res = res + Math.Pow(i, pw) + "\t";
    }

    return res;
}

int num = ReadData("Ведите число: ");

Console.WriteLine(LineBuilder(num, 1));
Console.WriteLine(LineBuilder(num, 2));