// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

int num1 = 0;

Console.WriteLine("Please, enter number: ");
num1 = int.Parse(Console.ReadLine()!);

if ((num1 %2) == 0)
{
  Console.WriteLine("The number is even!");
}
else
{
  Console.WriteLine("The number is odd!");
}