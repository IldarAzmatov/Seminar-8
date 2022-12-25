// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите колличество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[,] newArray = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
        newArray[j, i] = array[i, j];
    }
    Console.WriteLine(" ");
}
Console.WriteLine();
for (int k = 0; k < array.GetLength(1); k++)
{
    for (int l = 0; l < array.GetLength(0); l++)
    {
        Console.Write($"{newArray[k, l]} ");
    }
    Console.WriteLine(" ");
}