// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю

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

//counts sum of elements at odd indexes in the array
int OddIndexElemSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
}

//finds pairs in the array and output'em into console
void outPairs(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                Console.WriteLine($"{arr[i]}, {arr[j]} - {i}, {j}");
                arr[j] = Int32.MaxValue - j;//disables worked out; exception: fails if (MaxValue-j) is initially in the array, albeit very unlikely)
                break;
            }
        }
    }
}



int arrLng = ReadDataToInt("Enter a number of elements in array: ");//user enters the number of elements in arr to generate
int[] arr = Gen1DArrInt(arrLng, 1, 10);//generates a random array of 3-digit values
Print1DArr(arr); //output generated array into console

Console.WriteLine();
PrintAnswer("The sum of odd indexed elements is: ", OddIndexElemSum(arr));//counts & outputs the number of even values in the array


//* finds pairs in array
int[] testArr = arr;//to keep basic arr[] unchanged after processing
Console.WriteLine("\nPairs found:");
outPairs(testArr);