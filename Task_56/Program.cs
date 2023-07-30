// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

void GetSumMin(int[] SumArray)
{
    int minI = 0;
    for (int i = 0; i < SumArray.Length; i++)
    {
        if (SumArray[minI] > SumArray[i]) minI = i;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minI + 1}");
}

int[] GetSumRow(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow[i] += array[i, j];
        }
    }
    return sumRow;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GetCreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк в массиве: ");
int columns = GetInput("Введите количество столбцов в массиве: ");
int[,] array = GetCreateArray(rows, columns);
Console.WriteLine("Исходный массив: ");
Print2DArray(array);
int[] SumArray = GetSumRow(array);
Console.WriteLine($"Суммы элементов в строках: {String.Join(", ", SumArray)}");
GetSumMin(SumArray);