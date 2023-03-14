// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] GetRandomArray()
// {
//     int[] array = new int[4];

//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(-9, 10);
//     }
//     return array;
// }

// int[] ReverseElements(int[] array)
// {

//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// int[] myArray = GetRandomArray();
// Console.WriteLine($"Получившийся массив = [{string.Join(", ", myArray)}]");
// ReverseElements(myArray);
// Console.WriteLine($"Получившийся массив = [{string.Join(", ", myArray)}]");

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] GetRandomArray()
// {
//     int[] array = new int[4];

//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(-9, 10);
//     }

//     return array;
// }

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] myArray = {1, 2, 3, 4, 5};
int[] Digits = new int[myArray.Length / 2 + myArray.Length % 2];

for(int i = 0; i < myArray.Length / 2; i++)
{
    Digits[i] = myArray[i] * myArray[myArray.Length - 1 - i];
}
if(myArray.Length % 2 == 1)
{
    Digits[Digits.Length - 1] = myArray[myArray.Length / 2];
}
Console.WriteLine($"Получившийся массив = [{string.Join(", ", Digits)}]");