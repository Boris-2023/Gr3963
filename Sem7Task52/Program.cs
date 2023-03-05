// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//takes double value from console; replaces ',' with '.' if found
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0";

    inStr = inStr.Replace(',', '.');

    return (int.Parse(inStr));
}

//forms 2D int array of size countRow*countCol with random values <-> min & max
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

//finds mean values by columns of the array
double[] Mean2dArrCol(int[,] arr)
{
    double[] mean = new double[arr.GetLength(1)];

    for(int j =0; j<arr.GetLength(1); j++)
    {
        int sum = 0;
        for(int i=0; i<arr.GetLength(0); i++)
        {
            sum+= arr[i, j];
        }
        mean[j] = (double)sum/arr.GetLength(0);
    }

    return mean;
}

//prints 1D double array into console with Green, rounding to RoundDgtNum digits
void Print1DArrGreen(double[] arr, int RoundDgtNum)
{
    Console.ForegroundColor = ConsoleColor.Green;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            
            Console.Write($"{Math.Round(arr[i], RoundDgtNum)}\t");
            
        }
        Console.ResetColor();
        Console.WriteLine();
}


Console.Clear();

int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");

Console.WriteLine();
int[,] testArr = Gen2DArr(rowNum, colNum, 10, 99);
Print2DArr(testArr);

Print1DArrGreen(Mean2dArrCol(testArr), 2);//prints means by columns
Console.WriteLine();

