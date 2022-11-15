// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();

int[,] GetArray(int size1, int size2, int minValue, int maxValue)
{
    int[,] newArray = new int[size1, size2];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return newArray;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortingArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int m = 0; m < arr.GetLength(1); m++)
        {
            int temps = 0;
            for (int j = 0; j < arr.GetLength(1) - 1 - m; j++)
            {

                if (arr[i, j] < arr[i, j + 1])
                {
                    temps = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temps;
                }

            }
        }
    }
}


int[,] Array = GetArray(8, 12, 0, 9);
PrintArray(Array);
Console.WriteLine();
SortingArray(Array);
PrintArray(Array);