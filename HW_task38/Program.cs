// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

System.Console.WriteLine("Insert array size");
int myArraysize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[myArraysize];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine("Array ");
PrintArray(numbers);