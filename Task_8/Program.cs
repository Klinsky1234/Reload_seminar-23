/* 
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
double a = 0;
Console.WriteLine("Enter a number: ");
double.TryParse(Console.ReadLine()!, out a);
Console.Write($"{a} -> ");
for (int i = 2; i < a; i++)
{
    if (i % 2 == 0)
        Console.Write($"{i} ");
}

