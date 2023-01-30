/* Задача 1: Напишите программу, которая на вход принимает 2 числа и проверяет,
является ли пераое число квадратом второго
a =25; b = 5 -> yes 
a = 2; b = 10 -> No
//string user = Console.ReadLine()!; мы считываем строку, т.к. не ясно что введёт пользователь, поэтому не принимает int
// a = Convert.ToInt32(user); - он возьмёт user переведёт в инт и запишет в а для считывания чисел. 
// TryParse - мы берём юзер и пытаемся перевести его в "а", кароче как-то так мы можем ввести число и букву и проге будет похуй
Console.WriteLine("Enter a: ");
string user = ;// этой строкой считываем то что ввели выше 
int.TryParse(user, out a);// этим действие преобразовываем в int, если будут символы то выдаст "0"
Console.WriteLine($"{a}"); // как мы видим в "а" записалось наше введёное значение
а теперь оптимизируем  */
int a = 0, b = 0;
Console.WriteLine("Enter a: "); // забрали число 
int.TryParse(Console.ReadLine()!, out a); // считали со строки и преобразовали в инт 
Console.WriteLine("Enter b: ");
int.TryParse(Console.ReadLine()!, out b);
int c = b * b;
if (a == c)
{
    Console.WriteLine($"a = {a}; b = {b} -> Yes");
}
else
    Console.WriteLine($"a = {a}; b = {b} -> No"); // одно действие можно без скобок , а можно и с ними 