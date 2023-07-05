// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ChangeNumber(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int temp = 0;


    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i == 0)
            {
                temp = array[i, j];
                array[i, j] = array[row - 1, j];
                array[row - 1, j] = temp;
            }

        }
        Console.WriteLine();
    }
}


int[,] array = CreateArray(4, 4, 1, 9);
PrintArr(array);
ChangeNumber(array);
PrintArr(array);
