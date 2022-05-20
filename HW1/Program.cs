/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);

int rowMin = 0;
int collomnMin = 0;

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i, j] < array[rowMin, collomnMin])
        {
            rowMin = i;
            collomnMin = j;
        }
    }
}

Console.WriteLine();
Console.WriteLine(array[rowMin, collomnMin]);
Console.WriteLine();
PrintArray(RemoveArray(array, rowMin, collomnMin));

int[,] RemoveArray(int[,] inputArray, int row, int collomn)
{
    int[,] removeArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    for(int i = 0; i < removeArray.GetLength(0); i++)
    {
        for(int j = 0; j < removeArray.GetLength(1); j++)
        {
            if (i < row && j < collomn)
            {
                removeArray[i, j] = array[i, j];
            }
            else if (i < row && j >= collomn)
            {
                removeArray[i, j] = array[i, j+1];
            }
            else if (i >= row && j < collomn)
            {
                removeArray[i, j] = array[i+1, j];
            }
            else
            {
                removeArray[i, j] = array[i+1, j+1];
            }
        }
    }
    return removeArray;
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