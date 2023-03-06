// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// System.Console.WriteLine("Insert number");
// int number = Convert.ToInt32(Console.ReadLine());
// static List<uint> UintToDigits(uint number)
// {
//     var digits = new List<uint>();
//     while (number > 0)
//     {
//         digits.Add(number % 10);
//         number /= 10;
//     }

//     return digits;
// }

// static bool IsPalindrom(uint number)
// {
//     var digitList = UintToDigits(number);
//     for (int firstIndex = 0, lastIndex = digitList.Count - 1; firstIndex < lastIndex; ++firstIndex, --lastIndex)
//     {
//         if (digitList[firstIndex] != digitList[lastIndex]) return false;
//     }

//     return true;
// }

