// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

//read the data into int
int ReadData(string msg)
{
    Console.Write(msg);
    return(int.Parse(Console.ReadLine()??"0"));
}

//forms 1D array of length 'len' with random values <-> min & max
int[] Gen1DArr(int len, int min, int max)
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

bool SearchElemInArr(int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]==value) return true;
    }
    return false;
}

int[] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);

int num = ReadData("Enter a value to search in the array: ");

Console.WriteLine("If the element is in the array: {0}", SearchElemInArr(testArr, num));
