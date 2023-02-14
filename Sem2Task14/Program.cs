// Задача №14
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()??"0");

if(num1%23==0 && num1%7==0)
{
    Console.WriteLine("Число кратно 7 и 23!");
} else
{
    Console.WriteLine("Число не кратно 23 и 7!");
}

//Option 2
int rem1 = firstNumber%23;
int rem2 = firstNumber%7;

string? result = (rem1 == 0 && rem2 == 0) ? "кратно":"Не Кратно";
Console.WriteLine(result);