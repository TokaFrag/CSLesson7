// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void ModifedArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                array[i, j] = (array[i, j]) * (array[i, j]);
            }
        }
        Console.WriteLine();
    }
}


int[,] array = CreateArray(4, 5, 1, 9);
PrintArr(array);
ModifedArray(array);
PrintArr(array);


