// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька
// * Отсортируйте массив методом подсчета
// * Сравнить скорость работы метода пузырька и вставки

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

//output the result
void PrintAnswer(string explain, int num)
{
    Console.WriteLine(explain + num);
}

//counts even elements in the array
int CntEvenElemInArray(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0) cnt++;
    return cnt;
}

//sorts the array by bubble method
void BubbleSort(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

//sorts the array by counting method
void CountingSort(int[] arr, int[] arrSorted)
{
    int k;
    for (int i = 0; i < arr.Length; i++)
    {
        k = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
                k++;
        }
        arrSorted[k] = arr[i];
    }
}

//sorts the array by insertion method
void InsertionSort(int[] arr)
{
    int k, j;

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
int[] baseArr = Gen1DArrInt(arrLng, 100, 999);//generates a random array of 3-digit values
Print1DArr(baseArr); //output generated array into console

Console.WriteLine();
PrintAnswer("The number of even values in the array is: ", CntEvenElemInArray(baseArr));//counts & outputs the number of even values in the array


// * Estimates time for diff types of sorting

//sorts by Bubble & fixes time of process
Console.WriteLine("\nSorted by Bubble method:");
int[] arrSorted = baseArr;//array for Bubble sort

DateTime t1Start = DateTime.Now;//fixes start time
BubbleSort(arrSorted); //sorting
Print1DArr(arrSorted); //output array sorted by bubble into console
DateTime t1End = DateTime.Now;//fixes end time of process by Value


//sorts by Counting & fixes time of process
Console.WriteLine("\nSorted by Counting method:");
arrSorted = baseArr;//array for Counting sort

DateTime t2Start = DateTime.Now;//fixes start time
CountingSort(baseArr, arrSorted); //sorting
Print1DArr(arrSorted); //output array sorted by counting into console
DateTime t2End = DateTime.Now;//fixes end time of process by Value


//sorts by Insertion & fixes time of process
Console.WriteLine("\nSorted by Insertion method:");
arrSorted = baseArr;//array for Insertion sort

DateTime t3Start = DateTime.Now;//fixes start time
InsertionSort(arrSorted); //sorting
Print1DArr(arrSorted); //output array sorted by insertion into console
DateTime t3End = DateTime.Now;//fixes end time of process by Value


//outputs times elapsed for 3 different types of sorting
Console.WriteLine();
Console.WriteLine("Time elapsed by Bubble sort:\t {0}", t1End - t1Start);//time by Bubble sort
Console.WriteLine("Time elapsed by Counting sort:\t {0}", t2End - t2Start);//time by Counting sort
Console.WriteLine("Time elapsed by Insertion sort:\t {0}", t3End - t3Start);//time by Insertion sort