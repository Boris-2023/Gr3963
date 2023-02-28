// Задача №45
// Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//forms 1D array of length 'len' with random Int values <-> min & max
int[] Gen1DArrInt(int len, int min, int max)
{
    if (min > max) //to ensure min<max
    {
        int temp = min;
        min = max;
        max = temp;
    }

    int[] arr = new int[len];

    for (int i = 0; i < len; i++) arr[i] = new Random().Next(min, max + 1);

    return arr;
}

//prints 1D array into console
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Reverse an array with new array
int[] CopyArrStandardTool(int[] arr)
{
    int[] outArr = new int[arr.Length];
    arr.CopyTo(outArr, 0);// 0 - from which index to copy
    return outArr;
}


int arrLng = ReadDataToInt("Enter a number of elements in array: ");//user enters the number of elements in arr to generate
int[] arr = Gen1DArrInt(arrLng, 10, 100);//generates a random array of 3-digit values
Print1DArr(arr); //output generated array into console

Print1DArr(CopyArrStandardTool(arr));
