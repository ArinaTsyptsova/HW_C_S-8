// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ResultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return matrix3;
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
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rowFirst = GetInput("Введите количество строк в 1-ой матрице: ");
int colFirst = GetInput("Введите количество столбцов в 1-ой матрице: ");
int rowSec = GetInput("Введите количество строк во 2-ой матрице: ");
int colSec = GetInput("Введите количество столбцов во 2-ой матрице: ");

int[,] FirstMatix = GetCreateArray(rowFirst, colFirst);
int[,] SecondMatix = GetCreateArray(rowSec, colSec);
int[,] ThirdMatrix = ResultMatrix(FirstMatix, SecondMatix);

if (colFirst != rowSec) Console.WriteLine("Количество столбцов 1-ой матрицы должно быть ровно количеству строк 2-ой");

else
{
Console.WriteLine("Первая матрица: "); Print2DArray(FirstMatix);
Console.WriteLine("Вторая матрица: "); Print2DArray(SecondMatix);
Console.WriteLine("Результирующая матрица: "); Print2DArray(ThirdMatrix);
}