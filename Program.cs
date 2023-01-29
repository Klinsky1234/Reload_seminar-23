double n = 7, n1 = -8.5;
Console.Write($"{n} + ({n1}) = {n + n1}\n");
Console.WriteLine($"{n} - ({n1}) = {n - n1}");
Console.WriteLine($"{n} * ({n1}) = {n * n1}");
Console.WriteLine($"{n} : ({n1}) = {(double)n / n1}");// только в этом действи будет double
// Math (для double) и MathF (для float) - библиотеки -это нестандартный набор функций к торому мы можем обращаться 
// Math.Round - округление 
//Math.Abs(M) - модуль числа 
// что бы сохранить окруление Round или модуль числа надо куда это записать, поэтому создаим переменную М1 что бы записать М
double M = n / n1;
double M1;
double M2;
M1 = Math.Round(M);
M2 = Math.Abs(M);
Console.WriteLine($"M = {M1}\nМодуль числа = {M2}");
Console.WriteLine(Math.Round(M, 2)); // 2 -это кол-во знаков после запятой
