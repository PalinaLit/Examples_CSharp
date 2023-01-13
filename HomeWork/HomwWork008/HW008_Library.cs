


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

    /// <summary>
    /// Метод определения суммы элементов строки двумерного массива 
    /// и вывода строки с наименьшей суммой элементов
    /// </summary>
    /// <param name="matrix">двумерный массив</param>
    public static void MatrixLineElementSum (int[,] matrix)
    {
        int minSum = 0;
        int rowSum = 0;
        int result = 0;
        int columnNumber = 0;

        for ( int column = 0; column < matrix.GetLength(0); column++)
        {
            rowSum = 0;
            for ( int row = 0; row < matrix.GetLength(1); row++)
            {
                rowSum += matrix[column, row];
            }
            Console.WriteLine("Сумма элементов строки #" + column + " –> " + rowSum);
            
            if (rowSum < minSum)
            {
              result = rowSum;
              columnNumber = column;
            }
            minSum = rowSum;
        }
        Console.WriteLine();
        Console.WriteLine("Строка с минимальной суммой элементов равной – строка #" + columnNumber);

    }

    /// <summary>
    /// Метод заполнение трехмерного масива рандомными числами
    /// </summary>
    /// <param name="matrix">трехмерный массив</param>
    public static void CreatMatrix3D (int[,,] matrix)
    {
        int[] length = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
        int  number;
        for (int column = 0; column < length.GetLength(0); column++)
        {
            length[column] = new Random().Next(10, 100);
            number = length[column];
            if (column >= 1)
            {
            for (int row = 0; row < column; row++)
            {
                while (length[column] == length[row])
                {
                length[column] = new Random().Next(10, 100);
                row = 0;
                number = length[column];
                }
                number = length[column];
            }
            }
        }
        int count = 0; 
        for (int y = 0; y < matrix.GetLength(0); y++)
        {
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[y, x, z] = length[count];
                count++;
            }
            }
        }
    }

    /// <summary>
    /// Метод вывода трехмерного массива и индексом его элементов
    /// </summary>
    /// <param name="matrix">трехмерный массив</param>
    public static void Print3DMatrix (int[,,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                for (int three = 0; three < matrix.GetLength(2); three++)
                {
                    Console.Write( $"{matrix[rows,column,three]} {(rows,column,three)}    ");
                }
                Console.WriteLine();
            }
            // Console.WriteLine();
        }
    }

}
