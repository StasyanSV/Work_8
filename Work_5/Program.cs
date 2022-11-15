// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] GetArray(int size1)
{
    int[,] newArr = new int[size1, size1];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size1 * size1)
    {
        newArr[i, j] = num;
        if (i <= j + 1 && i + j < size1 - 1)
            ++j;
        else if (i < j && i + j >= size1 - 1)
            ++i;
        else if (i >= j && i + j > size1 - 1)
            --j;
        else
            --i;
        ++num;
    }
    return newArr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < 10) Console.Write($"0{arr[i, j]} ");
            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] Array = GetArray(4);
PrintArray(Array);
Console.WriteLine();