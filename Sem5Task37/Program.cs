// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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


int[] ConvertArray(int[] arr)
{
    int len = arr.Length/2;
    if(arr.Length%2==1) len++;

    int[] newArr = new int[len];

    for (int i = 0; i < len; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return newArr;
}


int[] testArr = Gen1DArr(13, -10, 10);
Print1DArr(testArr);

Print1DArr(ConvertArray(testArr));

