// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)



Console.Clear();

int[,,] GetArray3D(int size1, int size2, int size3, int minValue, int maxValue)
{

    int[] values = new int[maxValue-9];
    int num = minValue;
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = num++;
        // Console.Write($"{values[i]} ");
    }
// Console.WriteLine();
// Console.WriteLine();
    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(minValue, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;
    int[,,] newArr = new int[size1, size2, size3];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            for (int k = 0; k < newArr.GetLength(2); k++)
            {
                newArr[i, j, k] = values[valueIndex++];
            }
        }
    }
    return newArr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int m = 0; m < arr.GetLength(2); m++)
            {
                Console.Write($"{arr[i, j, m]} ({i},{j},{m}) ");
            }
        }
        Console.WriteLine();
    }
}


int[,,] Array = GetArray3D(2, 2, 2, 10, 99);
PrintArray(Array);
Console.WriteLine();