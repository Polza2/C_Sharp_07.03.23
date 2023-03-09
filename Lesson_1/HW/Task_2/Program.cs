// Напишите программу, которая принимает на вход три числа
// и выдает максимальное из этих чисел.

int num1 = 0;
int num2 = 0;
int num3 = 0;

Console.Write("Please, enter number1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Please, enter number2 = ");
num2 = int.Parse(Console.ReadLine()!);

Console.Write("Please, enter number3 = ");
num3 = int.Parse(Console.ReadLine()!);

int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine("Max is: ");
Console.WriteLine(max);