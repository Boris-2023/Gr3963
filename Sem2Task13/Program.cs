// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");

if(num>99)
{
    int digitsNum = 0;
    int temp = num;//service int variable for temporary use
    while(temp>=1) //counts total number of digits
    {
        temp/=10;
        digitsNum++;
    }

    temp = Convert.ToInt32(Math.Pow(10, digitsNum-3));//compose the divider till 3rd digit
    Console.WriteLine($"Третья цифра числа: {num/temp%10}");
} else
{
    Console.WriteLine("Третьей цифры нет!");
}
