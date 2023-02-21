// Задача №24
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int ReadData(string msg)
{
    Console.Write(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

//output the result
void PrintAnswer(string explain, int num)
{
    Console.WriteLine(explain + num);
}

//method to compute the result
int SumSimple(int num)
{
    int sum = 0;
    for (int i=1; i<=num; i++)
    {
        sum+=i;
    }
    return sum;
}

//method to compute the result by GAUSS
int SumGauss(int num)
{
    return ((1+num)*num)/2;//Gauss formula
}


int numberA = ReadData("Enter a value: ");

DateTime d1 = DateTime.Now;//fixes current time
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);//computes the difference in time => while of executing
PrintAnswer("The sum by Simple is: ", res1);

d1 = DateTime.Now;//fixes current time
int res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d1);//computes the difference in time => while of executing
PrintAnswer("The sum by Gauss is: ", res2);