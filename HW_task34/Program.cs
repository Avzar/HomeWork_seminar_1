// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

System.Console.WriteLine("Insert array size");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine("Array ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

System.Console.WriteLine($"{numbers.Length} numbers, {count} even");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
    numbers[j] = Random.Shared.Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        System.Console.WriteLine(numbers[j] + "  ");
    }
    System.Console.WriteLine();
}
