/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
int a = 0, b = 0;
Console.WriteLine("Enter a: ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine("Enter b: ");
int.TryParse(Console.ReadLine()!, out b);

if (a > b)
{
    Console.WriteLine($"{a} > {b} -> max = {a}");
}
else
{
    Console.WriteLine($"{a} < {b} -> max = {b}");
}
