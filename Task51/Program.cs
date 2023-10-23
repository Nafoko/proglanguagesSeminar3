﻿// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int SumElemIndexDiagonal(int[,] matrix)
{
    int sum = 0;
    int minSize = matrix.GetLength(0);
    if (minSize > matrix.GetLength(1)) minSize = matrix.GetLength(1);

    for (int i = 0; i < minSize; i++)
    {        
        sum += matrix[i,i];
    }
    return sum;
}

// int SumElemIndexDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i,j];
//             }
//         }
//     }
//     return sum;
// }

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" ]");
    }
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);
int res = SumElemIndexDiagonal(array2d);
Console.WriteLine($"сумма элементов на главной диагонали: {res} ");
