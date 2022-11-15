// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void CountSumLinesArray(int[,] arr)
{
    int[] newArr = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[i] += arr[i, j];
        }
    }

    for (int i = 0; i < newArr.Length; i++)
    {
        Console.Write($"{newArr[i]} ");
    }

    int min = newArr[0];
    int index = 0;
    for (int i = 1; i < newArr.Length - 1; i++)
    {
        if (min > newArr[i])
        {
            min = newArr[i];
            index = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Минимальная сумма элементов {min} в строке {index + 1}. ");


}



int[,] Array = GetArray(5, 8, 0, 9);
PrintArray(Array);
Console.WriteLine();
CountSumLinesArray(Array);