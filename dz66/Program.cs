// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте значение m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение n");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (m > n) { (m, n) = (n, m); }
for (int i=m; i<=n; i++)
sum = sum + i;
Console.Write($"{m}, {n} -> {sum}");
