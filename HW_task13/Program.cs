// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = Random.Shared.Next(10, 1000);
Console.WriteLine(number);
int firstdigit = number; 
int middledigit = number;
int lastdigit = number/ 10;
int result = middledigit % 10;
Console.WriteLine(result);
if (number < 100) 
{
    Console.WriteLine("Третьей цифры нет");
}
