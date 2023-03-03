// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//forms 2D array with random values <-> min & max
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

//sum the diagonal
int SumOfDiag(int[,] arr)
{
    int len = arr.GetLength(0)>arr.GetLength(1) ? len = arr.GetLength(1) : arr.GetLength(0);
    
    int sum = 0;
    for (int i = 0; i < len; i++) sum += arr[i,i];

    return sum;
}


int[,] testArr = Gen2DArr(10, 3, 10, 99);
Print2DArrRndColor(testArr);

Console.WriteLine($"Sum of diagonal: {SumOfDiag(testArr)}");
