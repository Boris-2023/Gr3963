// Задача №18
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).


// method to read from the user
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

int quarter = ReadData("Вdедите номер четверти: ");

//answer to the question
void PrintAnswer(int num)
{
    if (num == 1) Console.WriteLine("x>0, y>0");
    if (num == 2) Console.WriteLine("x>0, y<0");
    if (num == 3) Console.WriteLine("x<0, y<0");
    if (num == 4) Console.WriteLine("x<0, y>0");
}

if(quarter>0 && quarter<5)
{
   PrintAnswer(quarter);
}
else
{
    Console.WriteLine("Такой четверти не существует!");
}
