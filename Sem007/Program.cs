Console.Clear();

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

// int[,,] CreateArray(int row, int col, int z)
// {
//     int[,,] array = new int[row, col, z];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 array[i, j, k] = GetNextRandomUnicNumber();
//             }
//         }
//     }
//     return array;
// }
// int[] selectedNumbers = new int[89];

// int GetNextRandomUnicNumber()
// {
//     int number = new Random().Next(10, 100);
//     for (int i = 0; i < selectedNumbers.Length; i++)
//     {
//         if (selectedNumbers[i] == number)
//         {
//             return GetNextRandomUnicNumber();
//         }
//         else if (selectedNumbers[i] == 0)
//         {
//             selectedNumbers[i] = number;
//             break;
//         }
//     }
//     return number;
// }

// void Show3DArray(int[,,] arrayToShow)
// {
//     for (int i = 0; i < arrayToShow.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayToShow.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayToShow.GetLength(2); k++)
//             {
//                 Console.Write($"[{i},{j},{k}] = {arrayToShow[i, j, k]}\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// int[,,] array = CreateArray(2, 3, 2);
// Show3DArray(array);

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

// void showPascalTriangle(int[,] pascalTriangle)
// {
//     int spaceNumbers = pascalTriangle.GetLength(0);
//     for (int i = 0; i < pascalTriangle.GetLength(0); i++)
//     {
//         for (int k = 0; k < spaceNumbers; k++)
//         {
//             Console.Write("  ");
//         }
//         for (int j = 0; j <= i; j++)
//         {
//             Console.Write($" {pascalTriangle[i, j]}  ");
//         }
//         spaceNumbers--;
//         Console.WriteLine();
//     }



// }
// void showMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j] }");
//         }
//         Console.WriteLine();
//     }
// }

// int length = 10;
// int[,] pascalTriangle = new int[length, length];

// for (int i = 0; i < length; i++)
// {
//     for (int j = 0; j < length; j++)
//     {
//         if (i == j || j == 0)
//         {
//             pascalTriangle[i, j] = 1;
//         }
//         else if (i > j)
//         {
//             pascalTriangle[i, j] = pascalTriangle[i - 1, j - 1] + pascalTriangle[i - 1, j];
//         }
//     }
// }
// showMatrix(pascalTriangle);
// showPascalTriangle(pascalTriangle);

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 

// int[,] CreateSpiralArray(int rowLength, int colLength)
// {
//     int[,] arrayToReturn = new int[colLength, rowLength];
//     int number = 0;
//         int rightBorder = rowLength-1;
//         int leftBorder = 0;
//         int topBorder = 0;
//         int bottomBorder = colLength-1;
//         while (leftBorder <= rightBorder)
//         {
//             for (int j = leftBorder; j < rightBorder; j++)
//             {
//                 arrayToReturn[leftBorder, j] = number;
//                 number++;
//             }
//             for (int j = topBorder; j < bottomBorder; j++)
//             {
//                 arrayToReturn[j,rightBorder] = number;
//                 number++;
//             }
//             for (int j = rightBorder; j >= leftBorder; j--)
//             {
//                 arrayToReturn[bottomBorder,j] = number;
//                 number++;
//             }
//             for (int j = bottomBorder-1; j > topBorder; j--)
//             {
//                 arrayToReturn[j,leftBorder] = number;
//                 number++;
//             }
//             rightBorder--;
//             leftBorder++;
//             topBorder++;
//             bottomBorder--;
//         }
        
    
//     return arrayToReturn;
// }
// void Show2DArray(int[,] arrayToShow)
// {
//     for (int i = 0; i < arrayToShow.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayToShow.GetLength(1); j++)
//         {
//             Console.Write($"{arrayToShow[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] spiralArray = CreateSpiralArray(4,4);
// Show2DArray(spiralArray);
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////











