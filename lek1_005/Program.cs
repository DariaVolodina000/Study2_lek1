// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

Console.WriteLine("Введите число >");
double num = Convert.ToDouble(Console.ReadLine());
num = 1/num;
Console.WriteLine(num);