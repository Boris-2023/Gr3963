// Задача №39
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

//Reverse an array by reference type
void SwapArray(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

//Reverse an array with new array
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}

int arrLng = ReadDataToInt("Enter a number of elements in array: ");//user enters the number of elements in arr to generate
int[] arr = Gen1DArrInt(arrLng, 10, 100);//generates a random array of 3-digit values
Print1DArr(arr); //output generated array into console

//swap by reference type
Console.WriteLine();
SwapArray(arr);
Print1DArr(arr); //output generated array into console

//swap by new array
Console.WriteLine();
int[] testArr = SwapNewArray(arr);
Print1DArr(testArr); //output generated array into console
