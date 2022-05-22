/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */


int[,,] array = new int[3, 3, 3];

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
                bool found = false;
                while (!found)
                {
                    int temp = new Random().Next(10, 100);
                    for(int l = 0; l < collection.GetLength(0); l++)
                    {
                        for(int m = 0; m < collection.GetLength(1); m++)
                        {
                            for (int n = 0; n < collection.GetLength(2); n++)
                            {
                                if (temp == collection[i, j, k])
                                {
                                    found = true;
                                }
                                else
                                {
                                    collection[i, j, k] = temp;
                                }  
                            }
                        }
                    }             
                }
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
                Console.Write($"[{i}{j}{k}] {inputArray[i, j, k]} "); 
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}



