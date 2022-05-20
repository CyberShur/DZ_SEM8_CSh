/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 1];

FillArray(matrix1);
FillArray(matrix2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(ResultMatrix(matrix1, matrix2));

int[,] ResultMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        return matrix1;
    }
    
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(0)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
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