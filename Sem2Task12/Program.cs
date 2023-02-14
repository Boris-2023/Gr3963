// Задача №12
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число некратно первому, то программа выводит остаток от деления.

Console.Write("Введите число №1: ");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите число №2: ");
int num2 = int.Parse(Console.ReadLine()??"0");

int rem = num1%num2;
if(rem==0)
{
    Console.WriteLine("Второе число кратно первому!");
} else
{
     Console.WriteLine("Второе число не кратно первому, остаток равен: " + rem);
}

//Option 2
Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondtNum = Convert.ToInt32(Console.ReadLine());
int rem = firstNum % secondtNum;
if(rem == 0)
{
    Console.WriteLine($"Число {firstNum} кратно {secondtNum}");
}
else
Console.WriteLine($"Не кратно. Остаток от деления {firstNum} на {secondtNum} = {rem}");