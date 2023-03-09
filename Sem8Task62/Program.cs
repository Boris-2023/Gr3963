// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//fills 2D int array of side 'countSide' by a spiral 1-2-3-4.. CLOCKWISE
int[,] FillSquareSpiral(int countSide)
{
    int[,] arr = new int[countSide, countSide];

    int limLft = 0;
    int limRgt = countSide - 1;
    int value = 1;

    for (int circ = 0; circ < countSide / 2; circ++)//fills by "circles" clockwise
    {
        int adjustValue = countSide - 2 * circ - 1; //constant for particular circle - just for simplicity

        for (int i = limLft; i < limRgt; i++)//moves rightwards & downwards
        {
            arr[limLft, i] = value;//moves rightwards
            arr[i, limRgt] = value + adjustValue;//moves downwards
            value++;
        }
        value += adjustValue;//adjusts value as two directions were filled in at once

        for (int i = limRgt; i > limLft; i--)//moves leftwards
        {
            arr[limRgt, i] = value;//moves leftwards
            arr[i, limLft] = value + adjustValue;//moves upwards
            value++;
        }
        value += adjustValue;//adjusts value as two directions were filled in at once

        limLft++;//left limit increments
        limRgt--;//right limit decrements
    }

    if (countSide % 2 == 1) arr[countSide / 2, countSide / 2] = value;//fill the center for odd-sided squares

    return arr;
}

//prints 2D array into console
void Print2DArr(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }

}


Console.Clear();

int sideLen = ReadDataToInt("Enter a size of for side of the square: ");
Console.WriteLine();

int[,] spiral = FillSquareSpiral(sideLen);
Print2DArr(spiral);