Console.WriteLine("Enter two numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 / number2 == number2)
    {
        Console.WriteLine("Число являектся квадратом");
    }
    else
    {
        Console.WriteLine("Число не являектся квадратом");
    }

}
else
{
    if (number2 / number1 == number1)
    {
        Console.WriteLine("Число являектся квадратом");
    }
    else
    {
        Console.WriteLine("Число не являектся квадратом");
    }

}