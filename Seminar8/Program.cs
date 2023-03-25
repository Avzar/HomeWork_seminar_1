// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

void SwapArray(int[,] args)
{
    for(int j = 0; j < args.Length; j++)
    {
        int temp = args[0, j];
        args[0, j] = args[args.GetLength(0) - 1, j];
        args[args.GetLength(1) - 1, j] = temp;
    }
}

int[,] GenerateRandomArray(int Rows, int Columns, int min = 0, int max = 100)
{
    int[,] randomArray = new int[Rows, Columns];
    for(int i = 0; i < Rows; i++ )
    {
        for(int j = 0; j < Columns; j++)
        {
            randomArray[i, j] = Random.Shared.Next(min, max);
        }
    }
    return randomArray;
}

void Print2DArray(int[,]args)
{

    int Rows = args
    for(int i = 0; i < Rows; i++ )
    {
        for(int j = 0; j < Columns; j++)
        {
            randomArray[i, j] = Random.Shared.Next(min, max);
        }
    }
    return randomArray;
}

int[,] args = GenerateRandomArray(Random.Shared.Next(5, 11), Random.Shared.Next(5, 11));
