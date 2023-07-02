/* 
Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Задайте значение m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение n: ");
int n = int.Parse(Console.ReadLine()!);

PrintArray(GenerateDualArray(m, n));

// Функция для генерации двумерного массива со случайными вещественными числами
double[,] GenerateDualArray(int m, int n)
{
    double[,] dualArray = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            dualArray[i, j] = random.Next(-10, 10) + random.NextDouble();
        }
    }
    return dualArray;
}

// Функция вывода двумерного массива на печать
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F1}\t");
        }
        Console.WriteLine();
    }
}

