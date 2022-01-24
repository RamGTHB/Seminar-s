Console.Clear();

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// void fillArray(int[,] array, int length)
// {
//     for (int i = 0; i < length; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {
//             int currentRand = new Random().Next(-4, 3);
//             array[i, j] = (currentRand == 0) ? new Random().Next(1, 3) : currentRand;
//         }
//     }
// } 

// void showArray(int[,] array, int length)
// {
//     for (int i = 0; i < length; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {
//             Console.Write($"[{i}][{j}]: {array[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// } 

// int AbsArray(int[,] array, int length)
// {
//     int multiply = 1;
//     for (int i = 0; i < length; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {
//             array[i, j] = Math.Abs(array[i, j]);
//         }
//     }
//     return multiply;
// }

// int multiplyArray(int[,] array, int length)
// {
//     int multiply = 1;
//     for (int i = 0; i < length; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {
//             multiply *= array[i, j];
//         }
//     }
//     return multiply;
// }

// const int matrixLength = 5;

// int [,] twoDArray = new int[matrixLength, matrixLength];
// fillArray(twoDArray, matrixLength);
// showArray(twoDArray, matrixLength);
// int result = multiplyArray(twoDArray, matrixLength);
// Console.WriteLine($"Произведение массива {result}");
// twoDArray[4, 4] = 100;
// AbsArray(twoDArray, matrixLength);
// showArray(twoDArray, matrixLength);
// result = multiplyArray(twoDArray, matrixLength);
// Console.WriteLine($"Произведение массива {result}");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Показать двумерный массив размером m×n заполненный целыми числами


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Показать двумерный массив размером m×n заполненный вещественными числами
// Console.WriteLine("Введите N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите M");
// int M = Convert.ToInt32(Console.ReadLine());

// double[,] Array = new double[M, N];

// for (int i = 0; i < M; i++)
// {
//     for (int j = 0; j < N; j++)
//     {
//         Array [i, j] = new Random().NextDouble();
//         Console.Write(Array[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// В двумерном массиве n×k заменить четные элементы на противоположные
// Console.WriteLine("Введите N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите M");
// int M = Convert.ToInt32(Console.ReadLine());

// int[,] Array = new int[N, M];

// for (int i = 0; i < N; i++)
// {
//     for (int j = 0; j < M; j++)
//     {
//         Array [i, j] = new Random().Next(0, 10);
//         if(Array[i, j]  % 2 == 0)
//         {
//             Array[i, j] = Array[i, j] * (-1);
//         }
//         Console.Write(Array[i, j] + "\t");
//     }
//     Console.WriteLine();
// }



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задать двумерный массив следующим правилом: Aₘₙ = m+n


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// В матрице чисел найти сумму элементов главной диагонали


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Показать натуральные числа от 1 до N, N задано
// void showNaturalNumbers(int currentNumber, int N)
// {
//     if(currentNumber < N )
//     {
//         Console.Write($" {currentNumber},");
//         showNaturalNumbers(currentNumber + 1, N);
//     }
// }

// Console.WriteLine("Задайте N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// showNaturalNumbers(1, N);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Показать натуральные числа от N до 1, N задано
// Console.WriteLine("Введите N...");

// void showNaturalNumbers(int N )
// {
//     if(N >= 1)
//     {
//         Console.Write(N + "\t");
//         showNaturalNumbers(N - 1);
//     }
// }
// while (true)
// {
//     int N = Convert.ToInt32(Console.ReadLine());
//     if(N > 0)
//     {
//         showNaturalNumbers(N);
//         break;
//     }
//     else
//     {
//         Console.WriteLine("N должно быть положительным и больше (0). Введите N...");
//     }
// }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Показать натуральные числа от M до N, N и M заданы


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Написать программу копирования массива
// int[] CreateArray(int sizeArray, int min, int max)
// {
//     int[] arrayToReturn = new int[sizeArray];
//     Random rnd = new Random();
//     for (int i = 0; i < sizeArray; i++)
//     {
//         arrayToReturn[i] = rnd.Next(min, max);
//     }
//     return arrayToReturn;
// }

// void ShowArray(int[] arrayToShow, string nameOfArray)
// {
//     Console.WriteLine($"\n{nameOfArray}");
//     for (int i = 0; i < arrayToShow.Length; i++)
//     {
//         Console.Write($"{arrayToShow[i]} \t");
//     }
//     Console.WriteLine();
// }

// int[] CopyArray(int[] arrayToCopy)
// {
//     int[] copyArray = new int[arrayToCopy.Length];
//     for (int i = 0; i < arrayToCopy.Length; i++)
//     {
//         copyArray[i] = arrayToCopy[i];
//     }
//     return copyArray;
// }

// int[] resultArray = CreateArray(10, 1, 10);
// ShowArray(resultArray, "Первоначальный массив");
// int[] resultCopyArray = CopyArray(resultArray);
// resultArray[4] = 20;
// ShowArray(resultArray, "Измененный массив со значением 20 на месте 4 индекса");
// ShowArray(resultCopyArray, "Скопированный массив");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Выяснить являются ли три числа сторонами треугольника

// int a =3;
// int b =4;
// int c =5;

// if ((a+b)>c && (b+c)>a && (a+c)>b)
// {
//     Console.WriteLine("Это стороны треугольника");
// }
// else
// {
//     Console.WriteLine("Это не стороны треугольника");
// }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Написать программу преобразования десятичного числа в двоичное
// Console.WriteLine("Введи число...");
// int number = Convert.ToInt32(Console.ReadLine());
// string binary = Convert.ToString(number, 2);
// Console.WriteLine($"\nПеревел в двоичное {binary}\n");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1, k1 и b2, k2 заданы
// где: b1,2 - длина отрезка, k1,2 угловой коэффициент. 

Console.WriteLine("Введи к1...");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи b1...");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи к2...");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи b2...");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;

if (k1 != k2)
{
    x = (b1 - b2) / (k2 - k1);
    y = k1 * x + b1;
    Console.WriteLine($"\nПересечение в точке: X = {x}, Y = {y}\n");
}
else
{
    Console.WriteLine("\nНет пересечения\n");
}


