/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/


int[,] array = new int[6, 6];
FillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);

int[,] SortArray(int[,] inputArray)
{
    int temp = 0;
        
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int tempRow = i;
        int tempCollomn = 0;
        for (int j = 0; j < inputArray.GetLength(1) - 1; j++)
        {   
            tempRow = i;
            tempCollomn = j;
            for (int k = j + 1; k < inputArray.GetLength(1); k++)
            {
                if(inputArray[i,k] < inputArray[tempRow,tempCollomn])
                {
                    tempRow = i;
                    tempCollomn = k;
                }
            }
            temp = inputArray[i,j];
            inputArray[i,j] = inputArray[tempRow,tempCollomn];
            inputArray[tempRow,tempCollomn] = temp;
            
        }
    }
    return inputArray;
}

void FillArray(int[,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(0, 20);
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