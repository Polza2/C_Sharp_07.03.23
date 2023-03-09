// Напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее, а какое меньшее.

int num1 = 0;
int num2 = 0;
int max = 0;

Console.Write("Please, enter number1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Please, enter number2 = ");
num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2)
{
  Console.WriteLine("The numbers are equal!");
}
else
{
  if (num1 > num2)
  {
    max = num1;
    Console.WriteLine("First number is max: ");
    Console.WriteLine(max);
  }
  else
  {
    Console.WriteLine("Second number is max: ");
    Console.WriteLine(num2);
  }
}