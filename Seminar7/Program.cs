// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int [,] newArray(int Rows, int Columns)
// {
//     int [,] array = new int [Rows, Columns];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array [i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }
// int [,] myArray = newArray(4, 5);
// PrintMatrix (myArray);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// ​
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// int [,] newArray(int Rows, int Columns)
// {
//     int [,] array = new int [Rows, Columns];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array [i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FindOddIndex(int[,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 1 && j % 2 == 1)
//             {
//                 array[i,j] *= array[i,j]; 
//             }
//         }
//     }
// }

// int [,] array = newArray(4,3);
// PrintMatrix (array);
// FindOddIndex(array);
// PrintMatrix (array);

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

 int [,] newArray(int Rows, int Columns)
{
    int [,] array = new int [Rows, Columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = i + j;
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int FindDiagonale(int[,] array)
{
int result = 0;
 for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        {   
            result += array[i,i];
            
        }
    }
    return result;
}

int[,] array = newArray(5,5);
int sum = FindDiagonale(array);
PrintMatrix (array);
FindDiagonale(array);
System.Console.WriteLine(sum);