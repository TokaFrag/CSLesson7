// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

void PrintArr(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Print($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Print(string text)
{
    Console.Write(text);
}

int[,] CreateArray(int row, int col, int min, int max)
{
    Random random = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}



int[,] array = CreateArray(3, 4, -100, 100);
PrintArr(array);