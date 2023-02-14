// вывести случ число из 10-100 и показать его наиб цифру

System.Random numSintezator = new System.Random();// put the sintesator into memory

//Option 1
int rndNum = numSintezator.Next(10, 100);
Console.WriteLine(rndNum);

int num1 = rndNum/10;
int num2 = rndNum%10;

if(num1 > num2)
{
    Console.WriteLine("1st digit " + num1 + " is bigger then the second " + num2);
} else
{
    Console.WriteLine("Second digit " + num2 + " is bigger then the first " + num1);
}

//Option 2
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
int num1 = ((int)digits[0]) - 48;//in ASCI codes all digits are 48+digit
int num2 = ((int)digits[1]) - 48;

int res = (num1>num2)?res=num1:res=num2; //ternare

//option 3 - eat more memory - можно положить все возможные ответы в массив под индексами чисел - быстрее!!!
