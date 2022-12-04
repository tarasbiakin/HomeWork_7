// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
        }
    }
    return matrix;
}


double[] MatrixColomnsSum(double[,] matrix)
{
    
    double[]array = new double[matrix.GetLength(1)];
    int count =0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        
            sum += matrix[i, j];
            array[count]= sum/matrix.GetLength(0);
            count++;

    }
    return array;
}


void PrintMatrixDouble(double[] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i],2),4}, ");
        else Console.Write($"{Math.Round(array[i],2),4} ");
    }
    Console.WriteLine("]");

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



double[,] array2D = CreateMatrixRndInt(3, 4, -50, 50);
PrintMatrix(array2D);

double[] array = MatrixColomnsSum(array2D);
Console.WriteLine();
PrintMatrixDouble(array);