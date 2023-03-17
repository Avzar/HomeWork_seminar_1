// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Insert numbers");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"count of numbers > 0 = {sum}");

int[] StringToNum(string input);
{
    int count = 1;
    for(int i = 0; i < input.Length; i++)
    {
        
    }
}

void PrintArray(int[] array);
