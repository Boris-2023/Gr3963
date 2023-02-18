// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// method to read from the user
int ReadData(string msg)
{
    Console.Write(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

//output the answer
void PrintData(string msg, double value)
{
    Console.WriteLine(msg + value);
}

//to find the distance <-> 2 points in 3D coordinates
double CalcLen3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
}

int x1 = ReadData("Ведите координату Х точки №1: ");
int y1 = ReadData("Ведите координату Y точки №1: ");
int z1 = ReadData("Ведите координату Z точки №1: ");
int x2 = ReadData("Ведите координату Х точки №2: ");
int y2 = ReadData("Ведите координату Y точки №2: ");
int z2 = ReadData("Ведите координату Z точки №2: ");

Console.WriteLine();
PrintData("Расстояние между точками: ", CalcLen3D(x1, y1, z1, x2, y2, z2));
