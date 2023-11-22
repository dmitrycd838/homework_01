//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

int leftDigit = number / 10;
int rightDigit = number % 10;

if (leftDigit > rightDigit)
{
    System.Console.WriteLine($"{number} -> {leftDigit}");
}
else
{
    System.Console.WriteLine($"{number} -> {rightDigit}");
}

