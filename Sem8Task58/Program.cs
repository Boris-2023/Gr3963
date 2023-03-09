// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

//multiplies two matrixes; w/o dimensions check!
int[,] MultiplyMatrix(int[,] mtx1, int[,] mtx2)
{
    int temp = 0;
    int[,] product = new int[mtx1.GetLength(0), mtx2.GetLength(1)];

    for (int i = 0; i < mtx1.GetLength(0); i++)
    {
        for (int j = 0; j < mtx2.GetLength(1); j++)
        {
            temp = 0;
            for (int k = 0; k < mtx1.GetLength(1); k++)
            {
                temp += mtx1[i, k] * mtx2[k, j];
            }
            product[i, j] = temp;
        }
    }

    return product;
}


Console.Clear();

int rowNum1 = ReadDataToInt("Enter a number of rows for matrix #1:    ");
int colNum1 = ReadDataToInt("Enter a number of columns for matrix #1: ");

int rowNum2 = colNum1;//otherwise the matrices cannot have a product
int colNum2 = ReadDataToInt("Enter a number of columns for matrix #2: ");


int[,] mtx1 = Gen2DArr(rowNum1, colNum1, 1, 9);//generates 1st matrix
int[,] mtx2 = Gen2DArr(rowNum2, colNum2, 1, 9);//generates 2nd matrix

Console.WriteLine("\nMatrix #1:");
Print2DArr(mtx1);
Console.WriteLine("\nMatrix #2:");
Print2DArr(mtx2);
Console.WriteLine("\nThe product of these matrixes:");
Print2DArr(MultiplyMatrix(mtx1, mtx2));

