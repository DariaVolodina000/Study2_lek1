// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да


Console.WriteLine("Давайте проверим число, является ли число В квадратом числа А");
Console.WriteLine("Введите число А >");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В >");
int B = Convert.ToInt32(Console.ReadLine());

if (B == A*A) Console.WriteLine ($"Число {B} является квадратом числа {A}");
else Console.WriteLine ($"Число {B} не является квадратом числа {A}");
