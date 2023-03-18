// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
}

void columnAverage(int[,] matrix, double[] array)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            array[i] += (double) matrix[j, i] / matrix.GetLength(0);
        }
    }
}

void Main()
{
    const int ROWS = 4;
    const int COLUMNS = 3;
    const int LEFTBORDER = 0;
    const int RIGHTBORDER = 9;
    int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFTBORDER, RIGHTBORDER);
    PrintMatrix(myMatrix);
    double[] averageArray = new double[myMatrix.GetLength(1)];
    columnAverage(myMatrix, averageArray);
    Console.Write("Среднее арифметическое каждого столбца: ");
    PrintArray(averageArray);
    Console.WriteLine();
}

Main();