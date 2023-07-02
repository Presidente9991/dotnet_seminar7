/* 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 1, j = 2 -> 2
i = 4, j = 2 -> такого элемента не существует
*/
int[,] array = GetRandomArray(4, 4);
PrintArray(array);

Console.Write("Введите номер строки: "); 
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int columns = int.Parse(Console.ReadLine()!);

if (rows < 0 || columns < 0) Console.WriteLine("Введены некорректные данные");
else FindArrayElement(array, rows, columns);

int[,] GetRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindArrayElement(int[,] array, int rows, int columns)
{
    if (rows >= array.GetLength(0) || columns >= array.GetLength(1)) Console.WriteLine("Такого элемента не существует");
    else Console.WriteLine($"array[{rows}, {columns}] = {array[rows, columns]}");
}