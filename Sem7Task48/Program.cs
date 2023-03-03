// Задача №48
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

//takes double value from console; replaces ',' with '.' if found
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0";

    inStr = inStr.Replace(',', '.');

    return (int.Parse(inStr));
}

//forms 2D array of length 'len' with random values <-> min & max
int[,] Gen2DArrFormula(int countRow, int countCol)
{
 
    int[,] arr = new int[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = i + j;
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

Console.Clear();

int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");

int[,] testArr = Gen2DArrFormula(rowNum, colNum);
Print2DArrRndColor(testArr);