// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

// method to read from the user
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

int coordX = ReadData("Вdедите координыту X: ");
int coordY = ReadData("Вdедите координыту Y: ");

//answer to the question
void PrintQuarterTest(int x, int y)
{
    if(x>0 && y>0) Console.WriteLine("Точка в 1й четверти");
    if(x<0 && y>0) Console.WriteLine("Точка вo 2й четверти");
    if(x<0 && y<0) Console.WriteLine("Точка в 3й четверти");
    if(x>0 && y<0) Console.WriteLine("Точка в 4й четверти");
}

PrintQuarterTest(coordX, coordY);

