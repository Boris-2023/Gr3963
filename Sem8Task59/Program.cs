// Задача №59
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
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

//finds minimun element of the array
int[] FindMinIndex(int[,] arr)
{
    int[] index = new int[2];
    int minValue = int.MaxValue;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j]< minValue)
            {
                minValue = arr[i,j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}

//eliminate row and column of minimum element
int[,] Update2DArray(int[,] arr, int row, int col)
{
    int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i<row)
            {
                if(j<col) res[i,j] = arr[i,j];
                if(j>col) res[i,j-1] = arr[i,j];
            }
            if(i>row)
            {
                if(j<col) res[i-1,j] = arr[i,j];
                if(j>col) res[i-1,j-1] = arr[i,j];
            }
        }
    }
    return (res);
}

Console.Clear();

int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");

Console.WriteLine();
int[,] testArr = Gen2DArr(rowNum, colNum, 0, 100);
Print2DArr(testArr);

Console.WriteLine();
int[] minIndex = FindMinIndex(testArr);
int[,] updateArr = Update2DArray(testArr, minIndex[0], minIndex[1]);
Print2DArr(updateArr);

