// Задача №53
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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

//Changes first & last rows of the array
void ChangeFirstLastRows(int[,] arr)
{
    int temp = 0;
    int indLastRow = arr.GetLength(0)-1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0, i];
        arr[0, i] = arr[indLastRow, i];
        arr[indLastRow, i] = temp;
    }
}


int[,] testArr = Gen2DArr(5, 10, 10, 99);
Print2DArr(testArr);

Console.WriteLine();
ChangeFirstLastRows(testArr);
Print2DArr(testArr);

