// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}


//convert decimal number to binary
string DecToBin(int num)
{
    string res = string.Empty;
    while(num>0)
    {
        res = num%2 + res;
        num/=2;
    }

    return res;
}


int num = ReadDataToInt("Enter a decimal number: ");

Console.WriteLine("is equal to binary number: " + DecToBin(num));

//buit-in method 
Console.WriteLine(Convert.ToString(num, 2));//2 - binary, 10 - decimal and so on!
