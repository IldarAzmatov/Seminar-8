// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите колличество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[,] newArray = new int[n, m];
int rows = 0;
int min = 0;
int sum=0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine(" ");
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < min)
    {
        min = sum;
        rows++;
    }
}
Console.WriteLine(" ");
Console.WriteLine("строка " + (rows) + ", с суммой елементов равной: " + (min));