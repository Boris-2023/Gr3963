// Задача №11
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//Option 1
System.Random numSintezator = new System.Random();// put the sintesator into memory

int rndNum = numSintezator.Next(100, 1000);
Console.WriteLine(rndNum);

int num1 = rndNum%10;
int num2 = rndNum/100;

int res = num2*10 + num1;

Console.WriteLine("New figure is: " + res);


//Option 2
Random rnd = new Random();

rndNum = rnd.Next(100, 1000);
Console.WriteLine($"Рандомное число = {rndNum}");

int lastDigit = rndNum % 10;
int firstDigit = rndNum / 100;
rndNum = firstDigit * 10 + lastDigit;
Console.WriteLine($"Получившееся число = {rndNum}");

//Option 3
// System.Random numSintezator = new System.Random();
int rndNumber = numSintezator.Next(100,1000);
Console.WriteLine(rndNumber);

char [] digits1 = rndNumber.ToString().ToCharArray();

Console.WriteLine(int.Parse((digits1[0]).ToString())*10+int.Parse((digits1[2]).ToString()));