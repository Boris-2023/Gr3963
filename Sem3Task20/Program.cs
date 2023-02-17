// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


// method to read from the user
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

//output the answer
void PrintData(string msg, double value)
{
    Console.WriteLine(msg + value);
}

//to find the distance <-> 2 points in 2D coordinates
double CalcLen2D(int x1, int y1, int x2, int y2)
{
 //   return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
}

int x1 = ReadData("Ведите координату Х точки №1: ");
int y1 = ReadData("Ведите координату Y точки №1: ");
int x2 = ReadData("Ведите координату Х точки №2: ");
int y2 = ReadData("Ведите координату Х точки №2: ");

PrintData("Расстояние между точками: ", CalcLen2D(x1, y1, x2, y2));
