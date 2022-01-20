Console.Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// В прямоугольной матрице найти строку с наименьшей суммой элементов.

// void FillArray(int[,] array, int columnLength, int lineLength)
// {
//     for (int i = 0; i < columnLength; i++)
//     {
//         for (int j = 0; j < lineLength; j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//     }
// }

// void SumArray(int[,] array, int columnLength, int lineLength)
// {
//     int minIndex = 0;
//     int minSumArr = 0;
//     for (int k = 0; k < lineLength; k++)
//     {
//         minSumArr += array[0,k];
//     }
//     System.Console.WriteLine($"Sum line 0 is {minSumArr}");
//     for (int i = 1; i < columnLength; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < lineLength; j++)
//         {
//             sum += array[i, j];
//         }
//         System.Console.WriteLine($"Sum line {i} is {sum}");
//         if (minSumArr > sum)
//         {
//             minSumArr = sum;
//             minIndex = i;
//         }
//     }
//     System.Console.WriteLine($"{minIndex} line with the smallest sum of elements");
// }
// Console.WriteLine();

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Составить частотный словарь элементов двумерного массива



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Найти произведение двух матриц

// int[,] CreateMatrix(int row, int col)
// {
//     int[,] Matrix = new int[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             Matrix[i, j] = new Random().Next(0, row + col);
//         }
//     }
//     return Matrix;
// }

// void ShowMatrix(int[,] matrixToShow, string nameOfMatrix)
// {
//     Console.WriteLine($"{nameOfMatrix}");
//     for (int i = 0; i < matrixToShow.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixToShow.GetLength(1); j++)
//         {
//             Console.Write($"{matrixToShow[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (var i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (var j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (var k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 resultMatrix[i, j] += matrix1[i,k] * matrix2[k,j];
//             }
//         }
//     }
//     return resultMatrix;
// }

// int[,] matrix1 = CreateMatrix(2,3);
// ShowMatrix(matrix1, "Первая матрица");
// int[,] matrix2 = CreateMatrix(3,2);
// ShowMatrix(matrix2, "Вторая матрица");
// int[,] resultMatrix = ProductMatrix(matrix1, matrix2);
// ShowMatrix(resultMatrix, "Произведение матриц");


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

