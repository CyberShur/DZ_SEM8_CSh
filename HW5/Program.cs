/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */


int[,,] array = new int[4, 3, 3];

FillArray(array);
PrintArray(array);

    
void FillArray(int[,,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(2); k++)
            {
                collection[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] inputArray)
{
    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        for(int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write($"индекс [{i}{j}{k}] эллемент {inputArray[i, j, k]}, ");  // {massiv[i, j, k]}[{i},{j},{k}]
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}