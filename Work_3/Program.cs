// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] multiplyMatrix(int[,] arr, int[,] arr2)
{
    int[,] newArr = new int[arr.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            for (int m = 0; m < arr.GetLength(1); m++)
            {
                newArr[i, j] += arr[i, m] * arr2[m, j];
            }
        }
        Console.WriteLine();
    }
    return newArr;
}


int[,] Array1 = GetArray(2, 2, 0, 9);
int[,] Array2 = GetArray(2, 2, 0, 9);
PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);
Console.WriteLine();
int[,] Array3 = multiplyMatrix(Array1, Array2);
PrintArray(Array3);
Console.WriteLine();

