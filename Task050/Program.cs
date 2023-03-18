// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

int InputUserData(string messageToUser)
{
    int result;
    Console.Write(messageToUser);
    string userAnswer = string.Empty;
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine("You must enter an integer greater than 0");
        Console.Write(messageToUser);
    }
    
    return result;
}

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

bool isElementInMatrix(int row, int columns, int[,] matrix)
{
    if (row <= matrix.GetLength(0) && columns <= matrix.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
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
    int row = InputUserData("Enter row number: ");
    int column = InputUserData("Enter column number: ");
    if (isElementInMatrix(row, column, myMatrix))
    {
        Console.WriteLine($"{row} {column} -> {myMatrix[row - 1, column - 1]}");
    }
    else
    {
        Console.WriteLine($"{row} {column} -> there is no such element in the array");
    }
}

Main();
