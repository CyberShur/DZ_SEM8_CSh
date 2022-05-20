/* Задача 62: Заполните спирально массив 4 на 4.
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

int sizeArray = 4; 
int[,] array = new int[sizeArray, sizeArray];
int temp = 1;
int i = 0;
int j = 0;

while(temp <= sizeArray * sizeArray)
{
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sizeArray - 1)
    {    
        j++;
    }
    else if (i < j && i + j >= sizeArray - 1)
    {
        i++;
    }
    else if (i >= j && i + j > sizeArray - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

PrintArray(array);

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