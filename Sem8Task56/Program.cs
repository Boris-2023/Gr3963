// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

//finds the row with minimum sum of elements in the array
int MinRowCount(int[,] arr)
{
    int sum = 0, rowNum = -1;
    int minSum = int.MaxValue;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            sum+= arr[i,j];
        
        if(sum<minSum)
        {
            minSum = sum;
            rowNum = i;
        }
    }
    return rowNum + 1;
}

//output the result
void PrintAnswer(string explain, int num)
{
    Console.WriteLine("\n" + explain + num);
}


Console.Clear();

int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");

Console.WriteLine();
int[,] testArr = Gen2DArr(rowNum, colNum, 1, 9);//generates test array
Print2DArr(testArr);

PrintAnswer("Row #", MinRowCount(testArr));//the number of row with minimum sum of elements


