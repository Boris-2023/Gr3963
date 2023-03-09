// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//forms 3D int array of size countRow*countCol, countLayer with random values <-> min & max
int[,,] Gen3DArr(int countRow, int countCol, int countLayer, int min, int max)
{
    if (min > max) //to ensure min<max
    {
        int temp = min;
        min = max;
        max = temp;
    }

    int[,,] arr = new int[countRow, countCol, countLayer];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            for (int z = 0; z < countLayer; z++)
            {
                arr[i, j, z] = new Random().Next(min, max + 1);
            }
        }
    }
    return arr;
}

//prints 3D array by rows into console
void Print3DArr(int[,,] arr)
{

    for (int z = 0; z < arr.GetLength(2); z++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, z]} ({i},{j},{z})\t");
            }
            Console.WriteLine();
        }
    }

}


Console.Clear();

int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");
int layerNum = ReadDataToInt("Enter a number of layers:  ");

int[,,] testArr = Gen3DArr(rowNum, colNum, layerNum, 10, 99);//generates 3d array

Console.WriteLine("\nElements by rows:");
Print3DArr(testArr);