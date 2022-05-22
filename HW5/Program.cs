/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

int[,,] array = new int[3, 3, 3];

PrintArray(FillArray(array.GetLength(0), array.GetLength(1), array.GetLength(2)));

int[,,] FillArray(int i, int j, int k)
{
    int[,,] array = new int[i, j, k];
    int minNumber = 0;
    int number = 10;
    int[] temp = new int[89];

    for (int x = 0; x < temp.Length; x++)
    {    
        temp[x] = number++;
    }
    for (int l = 0; l < array.GetLength(0); l++)
        for (int m = 0; m < array.GetLength(1); m++)
            for (int n = 0; n < array.GetLength(2); n++)
            {
                int rndNumber = new Random().Next(minNumber, temp.Length);
                array[l, m, n] = temp[rndNumber];
                temp[rndNumber] = temp[minNumber];
                minNumber++;
            }
    return array;
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