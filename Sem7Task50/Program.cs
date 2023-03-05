// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// *Заполнить числами Фиббоначи и выделить цветом найденную цифру

//takes double value from console; replaces ',' with '.' if found
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0";

    inStr = inStr.Replace(',', '.');

    return (int.Parse(inStr));
}

//makes 1d Array of Fibonacci numbers
double[] FiboNumbers(int num)
{
    double[] res = new double[num];
    double first = 0;
    double last = 1;

    res[0] = 0;
    res[1] = 1;

    for(int i=2; i<num; i++)
    {
        res[i] = first+last;
        (first, last) = (last, first+last);
    }

    return res;
}

//forms 2D array with random values <-> min & max
double[,] Gen2DArrFibo(int countRow, int countCol)
{
 
    double[] fibo = FiboNumbers(countRow*countCol); //1d array of Fibonacci values
    double[,] arr = new double[countRow, countCol];

    int fiboCnt=0;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = fibo[fiboCnt];
            fiboCnt++;         
        }
    }
    return arr;
}

//prints 2D array into console
void Print2DArrDbl(double[,] arr)
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

//prints 2D array into console with selected item in green
void Print2DArrSelectItem(double[,] arr, int selectRow, int selectCol)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == selectRow && j == selectCol) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{arr[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//takes the position of the element to select and prints array if such elem exists or warning if the position is beyond the array
void SelectElementInArr(double[,] arr, int row, int col)
{
    if (row <= arr.GetLength(0)// if selection is within the array
    && col <= arr.GetLength(1)
    && row > 0
    && col > 0)
    {
        Print2DArrSelectItem(arr, row - 1, col - 1);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("There is no such element in the array!");
        Console.ResetColor();
    }
}



Console.Clear();

//initialization of the array & printing
int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");

double[,] testArr = Gen2DArrFibo(rowNum, colNum);
Print2DArrDbl(testArr);

//takes & shows selected element of the array
Console.WriteLine();
int rowSelect = ReadDataToInt("Selected element row #:    ");
int colSelect = ReadDataToInt("Selected element column #: ");

SelectElementInArr(testArr, rowSelect, colSelect);
Console.WriteLine();
