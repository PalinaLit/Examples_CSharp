public static class HW07_Library
{

    /// Метод заполнения матрицы рандомными целыми числами 
    /// </summary>
    /// <param name="matr">имя массива для заполнения</param>
    public static void FillArray(double[,] matr)
    {
        Random number = new Random();
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = Math.Round(number.NextDouble(), 1) + new Random().Next(0, 10);
                // $"{Math.Round(matr[i, j], 2)}");
            }
        }
    }

    /// <summary>
    /// Метод вывода матрицы (двумерного массива)
    /// </summary>
    /// <param name="matr">имя массива для вывода</param>
    public static void PrintArray (double[,] matr)
    { 
        for(int rows = 0; rows < matr.GetLength(0); rows++)
            {
                for(int j = 0; j < matr.GetLength(1); j++)
                {   
                Console.Write($"{matr[rows, j]}   ");
                }
            Console.WriteLine();           
            }
    }

}