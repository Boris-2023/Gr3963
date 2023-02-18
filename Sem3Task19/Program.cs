// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// *Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

Dictionary <int, string> palindBase = new Dictionary<int, string>();

//method to read data from console and return an integer
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

//fulfills the dictionary with all 4-digits palindromes and displays them upon request (ifShow!=0)
void FillPalindrome4Dgt(Dictionary <int, string> palindromes, int ifShow)
{
    int cnt = 0;
    for(int i=1; i<10; i++)
    {
        for(int j=0; j<10; j++)
        {
            cnt++;
            palindromes.Add(i*1000 + j*100 + j*10 + i, $"палиндром № {cnt}");
        }
    }

    //output the dictionary to console, if requested
    if(ifShow!=0)
    {
        foreach(var item in palindromes)
        {
            Console.WriteLine($"key: {item.Key}  value: {item.Value}");
        }
    }
}

//takes 5-digit value, deletes the center digit and return 4-digit value
int DeleteCenterDigitOf5(int num)
{
    return (num/1000)*100 + (num/10%10)*10 + num%10;
}

//returns the number of digits in input value
int NumberOfDigits(int num)
{
    return (int)(Math.Floor(Math.Log10(num))) + 1;
}



int num = ReadData("Введите пятизначное число: ");
//int digitsNum = (int)(Math.Floor(Math.Log10(num))) + 1;//gets the number of digits

if(NumberOfDigits(num)==5)
{
    FillPalindrome4Dgt(palindBase, 0);
 
    if(palindBase.ContainsKey(DeleteCenterDigitOf5(num)))
    {
        Console.WriteLine("Это палиндром!!!");
    } else
    { 
        Console.WriteLine("Это НЕ палиндром!");
    }
} else
{
    Console.WriteLine("Это не пятизначное число, попробуйте еще!");
}

