//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

double[,] CreateMatrixRndDouble(int rows, int columns, float MinValue, float MaxValue)
{
    double[,] matrix = new double[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * ((MaxValue - MinValue) + MinValue), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintMatrixSelekt(double[,] matrix, int i, int j)
{
    Console.Write($"{matrix[i, j],4} ");
}

try
{
    Console.Write("Введите  число строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите  число столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] array2D = CreateMatrixRndDouble(3, 4, -1, 10);

    PrintMatrix(array2D);
    if ((rows > array2D.GetLength(0)) || (columns > array2D.GetLength(1) || columns < 0 || rows < 0))
    {
        throw new Exception($"координаты не входят в размер массива");
    }

    PrintMatrixSelekt(array2D, rows, columns);

}
catch (FormatException)
{
    Console.WriteLine($"Было ведено не числовое значение");
}
catch (Exception ex)
{
    Console.WriteLine($"Такие {ex.Message}");
}

