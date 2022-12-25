//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайте значение N ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintNum(int N)
{
    Console.Write($"{N}, ");
    if(N>1)
    {
    PrintNum(N-1);
    }
}

PrintNum(n);