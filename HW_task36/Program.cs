// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0




System.Console.WriteLine("Insert array size");
int myArraysize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[myArraysize];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine("Array ");
PrintArray(numbers);
int sum = 0;

for(int i = 0; i < numbers.Length; i+=2)
sum = sum + numbers[i];

System.Console.WriteLine($"{numbers.Length} numbers, sum of all odd numbers = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = Random.Shared.Next(1,10);
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