/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */


int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки c минимальной суммой элементов: {RowMinimal(array)+1}");

int RowMinimal(int[,] inputArray)
{
    int temp = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum += inputArray[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            temp = i;
        }
    }
    return temp;
}

void FillArray(int[,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] inputArray)
{
    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        for(int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}