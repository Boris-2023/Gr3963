// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// *При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

//takes double value from console; replaces ',' with '.' if found
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0";

    inStr = inStr.Replace(',', '.');

    return (int.Parse(inStr));
}

//forms 2D double array with random values <-> min & max
double[,] Gen2DArrDbl(int countRow, int countCol, int min, int max)
{
    if (min > max) //to ensure min<max
    {
        int temp = min;
        min = max;
        max = temp;
    }

    double[,] arr = new double[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = new Random().Next(min, max) + new Random().NextDouble();
        }
    }
    return arr;
}

//prints 2D double array into console with random colors & rounding to roundDgtNum digits after dot
void Print2DArrDblRndColor(double[,] arr, int roundDgtNum)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    string buf;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //     Console.ForegroundColor = col[new Random().Next(0, 16)];
            //     Console.Write($"{Math.Round(arr[i, j], roundDgtNum)}\t");
            
            buf = Convert.ToString(Math.Round(arr[i, j], roundDgtNum));
            for (int x = 0; x < buf.Length; x++)
            {
                Console.ForegroundColor = col[new Random().Next(0, 16)];//set new color
                Console.Write(buf[x]);//output forthcoming symbol
            }
            Console.Write("\t");

        }
        Console.WriteLine();
    }
    Console.ResetColor();//reset color to Console default
}


Console.Clear();

int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");

double[,] testArr = Gen2DArrDbl(rowNum, colNum, 10, 99);
Print2DArrDblRndColor(testArr, 2);
