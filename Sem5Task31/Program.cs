// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

//forms 1D array of length 'len' with random values <-> min & max
int[] Gen1DArr(int len, int min, int max)
{
    if (min > max) //to ensure 
    {
        int temp = min;
        min = max;
        max = temp;
    }

    int[] arr = new int[len];

    for (int i = 0; i < len; i++) arr[i] = new Random().Next(min, max + 1);

    return arr;
}

//prints 1D array into consle
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

(int posSum, int negSum) NegPosSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) posSum += arr[i];
        if (arr[i] < 0) negSum += arr[i];
    }

    return (posSum, negSum);
}

int[] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);

(int posit, int negat) results = NegPosSum(testArr);
PrintData("Sum of positive elements:", results.posit);
PrintData("Sum of negative elements:", results.negat);
