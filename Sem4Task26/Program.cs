// Задача №26
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int ReadData(string msg)
{
    Console.Write(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

//computes a number of digits in a value
int NumberOfDigits(int num)
{
    return (int)(Math.Log10(num)) + 1;
}

//to print result into console
void PrintAnswer(string explain, int num)
{
    Console.WriteLine(explain + num);
}

int num = ReadData("Enter a value: ");
PrintAnswer("The number of digits: ", NumberOfDigits(num));



//to string!!!
PrintAnswer("The number of digits: ", num.ToString().Length);