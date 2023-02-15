// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

var daysOfWeek = new Dictionary <int, string> ()
{
    [1] = "нет",
    [2] = "нет",
    [3] = "нет",
    [4] = "нет",
    [5] = "нет",
    [6] = "да",
    [7] = "да"
};

Console.Write("Введите номер дня недели: ");
int dayWeekNum = int.Parse(Console.ReadLine()??"0");

if(dayWeekNum>0 && dayWeekNum<8)
{
  Console.WriteLine(daysOfWeek[dayWeekNum]);
} else
{
    Console.WriteLine("Это не номер дня недели! Введите число от 1 до 7.");
}

