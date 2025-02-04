﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Random rand = new Random();
// Console.WriteLine(rand.NextDouble()); [0.0, 1.0)
//Console.WriteLine(rand.NextDouble() * 10); // [0.0, 10.0)
Console.WriteLine($"{rand.NextDouble() * 10 - 5:f2}"); // [-5.0, 5.0)
Console.WriteLine($"{rand.NextDouble() * (13.0 + 7.0) - 7.0:f2}"); // [-7.0, 13.0)
//rand.NextDouble() * (maxValue + minValue) + minValue


Console.Clear();
// double[,] FillMatrix(int rowsCount, int columnsCount)
// {
//     double[,] matrix = new double[rowsCount, columnsCount];
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.NextDouble() * 100 + 20;
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]:f2}" + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите число строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = FillMatrix(m, n);
// PrintMatrix(matrix);


void InputMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(-9, 10) * new Random().NextDouble();
      Console.Write($"{matrix[i, j]:f2} \t");
    }
    Console.WriteLine();
  }


}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];
InputMatrix(matrix);