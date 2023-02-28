// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = Random.Shared.Next(100,1000);
Console.WriteLine(number);
int firstdigit = number; 
int middledigit = number / 10;
int lastdigit = number;
int result = middledigit % 10;
Console.WriteLine(result);