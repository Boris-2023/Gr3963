// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//* Отсортируйте массив методом вставки

int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//forms 1D double array of length 'len' with random Int values <-> min & max
double[] Gen1DArrDbl(int len, int min, int max)
{
    if (min > max) //to ensure min<max
    {
        int temp = min;
        min = max;
        max = temp;
    }

    double[] arr = new double[len];

    for (int i = 0; i < len; i++) arr[i] = new Random().Next(min, max) + new Random().NextDouble();

    return arr;
}

//prints 1D double array into console
void Print1DArrDbl(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//sorts the double array by insertion method
void InsertionSortDbl(double[] arr)
{
    double k;
    int j;

    for (int i = 1; i < arr.Length; i++)
    {
        k = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] > k)
        {
            arr[j + 1] = arr[j];
            arr[j] = k;
            j--;
        }
    }
}


int arrLng = ReadDataToInt("Enter a number of elements in array: ");//user enters the number of elements in arr to generate
double[] arr = Gen1DArrDbl(arrLng, -100, 100);//generates a random double array
Print1DArrDbl(arr); //output generated array into console

double[] arrSort = arr;
InsertionSortDbl(arrSort);//sort by insertion
Console.WriteLine("\nArray sorted by Insertion method:");
Print1DArrDbl(arrSort); //output generated array into console

Console.WriteLine("\nThe difference between Max & Min elements of the array is: {0}", arrSort[arrLng-1]-arrSort[0]);//(Max-Min) output




