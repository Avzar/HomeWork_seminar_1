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




// Console.WriteLine("Insert array");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Array: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }