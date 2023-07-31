// Задача 60 ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Print3DArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write(array[x, y, z] + "(" + x + "," + y + "," + z + ")" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] GetCreate3DArray(int field, int rows, int columns)
{
    int[,,] array = new int[field, rows, columns];
    int count = 1;
    for (int x = 0; x < field; x++)
    {
        for (int y = 0; y < rows; y++)
        {
            for (int z = 0; z < columns; z++)
            {
                array[x, y, z] += count;
                count += 15;
            }
        }
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int field = GetInput("Введите количество полей в массиве: ");
int rows = GetInput("Введите количество строк в массиве: ");
int columns = GetInput("Введите количество столбцов в массиве: ");
int[,,] array = GetCreate3DArray(field, rows, columns);
Print3DArray(array);
