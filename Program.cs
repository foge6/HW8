int[,] Create2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

// int[,] SortingRows(int[,] array)
// {

//     int maxi = 0;
//     int maxj = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             int max = array[j, k];
//             for (int i = k; i < array.GetLength(1); i++)
//             {
//                 if (array[j, i] > max)
//                 {
//                     int temp = array[j, i];
//                     array[j, i] = max;
//                     array[maxj, maxi] = temp;
//                     max = temp;
//                 }
//             }
//             maxi++;
//             // System.Console.Write(maxi + " ");
//         }
//         maxi = 0;
//         maxj++;
//         // System.Console.WriteLine();
//         // System.Console.Write(maxj + " ");
//     }

//     return array;
// }
// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);
// System.Console.WriteLine();
// int[,] sort = SortingRows(array);
// Show2dArray(sort);

// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// void FindRow(int[,] array)
// {
//     int max = 0;
//     int maxrow = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//     int summ = 0;
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//            summ += array[j,i];
//         }
//         if (summ>max)
//         {
//         max=summ;
//         maxrow = j;
//         }
//     }
//     System.Console.WriteLine($"Max summ row in: {maxrow} row");
// }
// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// if (m==n && m >0)
// {
// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);
// System.Console.WriteLine();
// FindRow(array);
// }
// else
// System.Console.WriteLine("row and col must be equal");


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] Matrix(int[,] array1, int[,] array2)
// {
// int[,]array = new int[array1.GetLength(0),array1.GetLength(1)];
// for (int j = 0; j < array1.GetLength(0); j++)
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         int summ = array1[j, 0] * array2[0, i];
//             for (int k = 1; k < array1.GetLength(0); k++)
//             {
//                summ = summ +  array1[j, k] * array2[k, i];
//             }
//         array[j,i]=summ;
//     }
// }
// return array;
// }
// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// if (m==n && m!=0)
// {
// int[,] array1 = Create2dArray(m, n, min, max);
// int[,] array2 = Create2dArray(m, n, min, max);
// Show2dArray(array1);
// System.Console.WriteLine();
// Show2dArray(array2);
// int[,] arr = Matrix(array1,array2);
// System.Console.WriteLine();
// Show2dArray(arr);
// }
// else
// System.Console.WriteLine("row and col must be equal");


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int Find3dArray(int[,,] array, int number)
// {
//     int count = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//            for (int k = 0; k < array.GetLength(2); k++)
//            {
//             if (array[j, i, k]==number)
//             count++;
//            }
            
//         }
//     }
//     return count;
// }

// int[,,] Create3dArray(int rows, int cols, int lines, int min, int max)
// {
//     int[,,] array = new int[rows, cols, lines];
//     for (int j = 0; j < rows; j++)
//     {
//         for (int i = 0; i < cols; i++)
//         {
//             for (int k = 0; k < lines; k++)
//             {
//                 array[j, i, k] = new Random().Next(min, max);
//                 while(Find3dArray(array,array[j,i,k]) > 1)
//                 {
//                 array[j, i, k] = new Random().Next(min, max);
//                 }
//             }
//         }
//     }
//     return array;
// }

// void Show3dArray (int[,,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 System.Console.Write($"{array[j,i,k]}({j},{i},{k}) ");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,,] array = Create3dArray(2, 2, 2, 10, 100);
// Show3dArray(array);

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] CreateSpiral(int rows, int cols, int count)
// {
// int[,] array = new int[rows,cols];
//    for (int i = 0; i < cols; i++)
//    {
//         array[0, i] = count;
//         count++;
//     }
//     for (int j = 1; j < rows; j++)
//     {
//         array[j, 3] = count;
//         count++;
//     }
//     for (int k = 2; k >= 0; k--)
//     {
//         array[3,k] = count;
//         count++;
//     }
//     for (int r = 2; r >0; r--)
//     {
//         array[r,0] = count;
//         count++;
//     }
//     for (int s = 1; s < 3; s++)
//     {
//         array[1,s] = count;
//         count++;
//     }
//     for (int a = 2; a > 0; a--)
//     {
//         array[2, a] = count;
//         count++;
//     }
//     return array;
// }
// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Write first number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateSpiral(m, n, number);
// Show2dArray(array);
