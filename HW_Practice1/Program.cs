
System.Console.WriteLine("Insert array size ");
int array1 = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[array1];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine(Console.ReadLine());
// PrintArray(numbers);
int sum = 0;
int count = 0;

for(int i = 0; i < numbers.Length; i++)
sum = sum + numbers[i];
count = count++;
System.Console.WriteLine($"{numbers} сумма чисел {count} ");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
    numbers[j] = Random.Shared.Next(10,100);
    }
}

// void PrintArray(int[] numbers)
// {

// }