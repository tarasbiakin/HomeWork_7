// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int rows, int columns, float MinValue, float MaxValue)
{
    double[,] matrix = new double[rows, columns];
  
   Random rnd = new Random();
   
    for (int i = 0; i < matrix.GetLength(0); i++) //3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(2)
        { 
             matrix[i, j] =  rnd.NextDouble()*((MaxValue-MinValue)+MinValue);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(matrix[i, j],2),4}, ");
            else Console.Write($"{Math.Round(matrix[i, j],2),4} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2D = CreateMatrixRndDouble(3, 4,-1,10);
PrintMatrix(array2D);



// Console.WriteLine("Введите  чисело строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите  чисело столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите минимальное число: ");
// float MinValue = Convert.ToInt64(Console.ReadLine());

// Console.WriteLine("Введите максимальное число: ");
// float MaxValue = Convert.ToInt64(Console.ReadLine());



//(int,int,float,float) typle = (rows,columns,MinValue,MaxValue);

