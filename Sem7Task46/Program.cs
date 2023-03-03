// Задача №46
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

//takes double value from console; replaces ',' with '.' if found
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0";

    inStr = inStr.Replace(',', '.');

    return (int.Parse(inStr));
}

//forms 2D array of length 'len' with random values <-> min & max
int[,] Gen2DArr(int countRow, int countCol, int min, int max)
{
    if (min > max) //to ensure min<max
    {
        int temp = min;
        min = max;
        max = temp;
    }

    int[,] arr = new int[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

//prints 2D array into console
void Print2DArrRndColor(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write($"{arr[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }

}


int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");

int[,] testArr = Gen2DArr(rowNum, colNum, 10, 99);
Print2DArrRndColor(testArr);