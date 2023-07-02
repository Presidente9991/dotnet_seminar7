/* 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
* Сумма всех цифр / их количество(это количество ваших строк)
*/

int[,] array = GenerateDualArray();
PrintArray(array);
Console.WriteLine("");
Console.WriteLine(string.Join("\t", GetSumOfRows(array)));

int[,] GenerateDualArray(int rows = 4, int columns = 4)
{
    int[,] dualArray = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dualArray[i, j] = random.Next(0, 10);
        }
    }
    return dualArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

float[] GetSumOfRows(int[,] array)
{
    float[] sums = new float[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sums[i] += array[j, i];
        }
        sums[i] /= array.GetLength(0);
    }
    return sums;
}

