/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
int a = 0, b = 0, c = 0;
Console.WriteLine("Enter a: ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine("Enter b: ");
int.TryParse(Console.ReadLine()!, out b);
Console.WriteLine("Enter c: ");
int.TryParse(Console.ReadLine()!, out c);

int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($" max = {max}");