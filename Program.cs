// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// int[,] resultMatrix = GetMatrix(3, 3);

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }

// PrintMatrix(resultMatrix);

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();
// PrintMatrix(SortElenemt(resultMatrix));

// int[,] SortElenemt(int[,] matrix1)
// {

//     // int lastIndex = matrix1.GetLength(0) - 1;
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < matrix1.GetLength(1); k++)
//             {
//                 if (matrix1[i,k] > matrix1[i,j])
//                 {
//                    int temp = matrix1[i,j];
//                    matrix1[i,j] = matrix1[i,k];
//                    matrix1[i,k] = temp;
//                 }
//             } 
//         }

//     }
//     return matrix1;
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// int[,] resultMatrix = GetMatrix(3, 3);

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }

// PrintMatrix(resultMatrix);

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }



// int GetRowNumber(int[,] matrix)
// {
//     int rowMin = 0; 
//     int minSum = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         minSum = minSum + matrix[0, i];
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = int.MinValue;
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             sum = sum + matrix[i,j];
//         }

//         if (minSum > sum)
//         {
//             minSum = sum;
//             rowMin = i + 1;
//         }
//     }
//     return rowMin;
// }

// Console.WriteLine($"Наиманьшая сумма в строке: {GetRowNumber(resultMatrix)}");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

// int[,] matrix1 = GetMatrix(3, 3);
// int[,] matrix2 = GetMatrix(3, 3);

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }

// PrintMatrix(matrix1);
// Console.WriteLine();
// PrintMatrix(matrix2);

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();
// PrintMatrix(GetMultiplicationMatrix(matrix1, matrix2));

// int[,] GetMultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
//     int[,] resultMatrix = new int[firstMatrix.GetLength(0),firstMatrix.GetLength(1)];
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < resultMatrix.GetLength(1); k++)
//             {
//                 resultMatrix[i,j] = firstMatrix[i,j] * secondMatrix[i,j];
//             }
//         }
//     }
//     return resultMatrix;
// }


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// double [,,] resultMatrix = GetMatrix(2, 2, 2);

// double [,,] GetMatrix(int m, int n, int z)
// {
    
//     double [,,] matrix = new double [m, n, z];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 for (int l = 0; l < 5; l++)
//                 {
//                     int count = new Random().Next(10,100);
//                     matrix[i,j,k] += count; 
//                 }  
//             }
//         }
//     }
//     return matrix;
// }

// PrintMatrix(resultMatrix);

// void PrintMatrix(double[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 Console.Write($" {matrix[i, j, k]}({i},{j},{k}) " );    
//             }
//             Console.WriteLine();
            
//         }
        
//     }
    
// }