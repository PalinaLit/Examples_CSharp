


public static class Hw008_Library
{

    /// <summary>
    /// Метод заполнения матрицы рандомными целыми числами 
    /// </summary>
    /// <param name="matr">имя массива для заполнения</param>
    public static void FillMatrixInt(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

    /// <summary>
    /// Метод вывода матрицы (двумерного массива)
    /// заполненной целвми числами
    /// </summary>
    /// <param name="matr">имя массива для вывода</param>
    public static void PrintMatrixInt(int[,] matr)
    { 
        for(int rows = 0; rows < matr.GetLength(0); rows++)
            {
                for(int j = 0; j < matr.GetLength(1); j++)
                {   
                Console.Write($"{matr[rows, j]} ");
                }
            Console.WriteLine();           
            }
    }

    /// <summary>
    /// Метод построения по убыванию элементов
    /// каждой строки двумерного массива
    /// </summary>
    /// <param name="matrix">двумерный массив</param>
    public static void AscendingMatrixStringNumbers (int[,] matrix)
    {
        for ( int column = 0; column < matrix.GetLength(0); column++)
            {
                for ( int row = 0; row < matrix.GetLength(1); row++)
                    {
                        for (int r = 0; r < matrix.GetLength(1) - 1; r++)
                        {
                            if (matrix [column, r + 1] > matrix [column, r])
                            {
                                int place = matrix [column, r + 1];
                                matrix [column, r + 1] = matrix [column, r];
                                matrix [column, r] = place;
                            }
                        }
                    }
            }           
    }
}
