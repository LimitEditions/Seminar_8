// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, colums];

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void ArrangeStringMaxToMin()
// {
//     int temp = 0;
//     for (int k = 0; k < matrix.GetLength(1); k++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//             {
//                 if (matrix[i, j] < matrix[i, j + 1])
//                 {
//                     temp = matrix[i, j];
//                     matrix[i, j] = matrix[i, j + 1];
//                     matrix[i, j + 1] = temp;
//                 }
//             }
//         }
//     }

// }

// FillMatrix();
// PrintMatrix();
// Console.WriteLine();
// ArrangeStringMaxToMin();
// PrintMatrix();




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, colums];

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int FindStringWithMinSumm()
// {
//     int numberString = 1;
//     int[] array = new int[matrix.GetLength(0)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         array[i] = sum;
//         Console.Write(array[i] + " ");
//     }

//     Console.WriteLine("\n");

//     int minNum = array[0];

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         if (array[i] < minNum)
//         {
//             minNum = array[i];
//             numberString = i + 1;
//         }
//     }
//     return numberString;
// }

// FillMatrix();
// PrintMatrix();
// Console.WriteLine();
// Console.WriteLine("строка " + FindStringWithMinSumm());


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите число строк матрицы 1");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов матрицы 1");
// int colums1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число строк матрицы 2");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов матрицы 2");
// int colums2 = Convert.ToInt32(Console.ReadLine());
// int[,] matrix1 = new int[rows1, colums1];
// int[,] matrix2 = new int[rows2, colums2];
// int[,] multiplicationMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < 100)
//             {
//                 Console.Write(matrix[i, j] + "  ");
//             }
//             else
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// void FillMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// int[,] MultiplicationMatrix()
// {
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix2.GetLength(0); k++)
//             {
//                 multiplicationMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }
//     return (multiplicationMatrix);
// }

// FillMatrix(matrix1);
// FillMatrix(matrix2);
// PrintMatrix(matrix1);
// Console.WriteLine();
// PrintMatrix(matrix2);
// Console.WriteLine();
// if (matrix1.GetLength(1) == matrix2.GetLength(0))
// {
//     PrintMatrix(MultiplicationMatrix());
// }
// else
// {
//     System.Console.WriteLine("Число столбцов матрицы 1 должно равняться числу строк матрицы 2");
// }




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число блоков");
// int bloks = Convert.ToInt32(Console.ReadLine());
// int[,,] massiv = new int[rows, colums, bloks];

// void PrintMassiv()
// {
//     for (int i = 0; i < massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             for (int k = 0; k < massiv.GetLength(2); k++)
//             {
//                 Console.WriteLine($"{massiv[i, j, k]} ({i}, {j}, {k})");
//             }
//         }
//     }
// }

// void FillMassiv()
// {
//     for (int i = 0; i < massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             for (int k = 0; k < massiv.GetLength(2); k++)
//             {
//                 massiv[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
// }

// FillMassiv();
// PrintMassiv();



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] matrix = new int[4, 4];

// void PrintMatrix()
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

// void FillMatrix()
// {
//     int startNumber = 1;
//     int startX = 0, startY = 0, i = 0;
//     int endX = matrix.GetLength(0) - 1;
//     int endY = matrix.GetLength(1) - 1;
//     while (startX <= endX && startY <= endY)
//     {
//         for (i = startY; i <= endY; i++)
//         {
//             {
//                 matrix[startX, i] = startNumber++;
//             }
//         }
//         startX++;
//         for (i = startX; i <= endX; i++)
//         {
//             {
//                 matrix[i, endY] = startNumber++;
//             }
//         }
//         endY--;
//         for (i = endY; i >= startY; i--)
//         {
//             matrix[endX, i] = startNumber++;
//         }
//         endX--;
//         for (i = endX; i >= startX; i--)
//         {
//             matrix[i, startY] = startNumber++;
//         }
//         startY++;
//     }
// }

// FillMatrix();
// PrintMatrix();