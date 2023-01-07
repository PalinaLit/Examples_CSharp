public static class HW07_Library
{

    /// Метод заполнения матрицы рандомными вещественными числами 
    /// </summary>
    /// <param name="matr">имя массива для заполнения</param>
    public static void FillArrayDouble(double[,] matr)
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
    /// заполненной вещественными числами
    /// </summary>
    /// <param name="matr">имя массива для вывода</param>
    public static void PrintArrayDouble(double[,] matr)
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

    // <summary>
    /// Метод ввода целого числа от пользователя
    /// </summary>
    /// <param name="text">текс, который видит юзер перед вводом числа</param>
    /// <returns></returns>
    public static int UserInputIntNumber(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    /// <summary>
    /// Метод заполнения матрицы рандомными целыми числами 
    /// </summary>
    /// <param name="matr">имя массива для заполнения</param>
    public static void FillArrayInt(int[,] matr)
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
    public static void PrintArrayInt(int[,] matr)
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

    public static void FindANDPrintMatrixFigureInt (int[,] matrix)
    {
        Console.WriteLine("Введите позицию элемента в двумерном массиве");
        int a = UserInputIntNumber("Укажите строку: ");
        Console.WriteLine();
        int b = UserInputIntNumber("Укажите столбец: ");
        Console.WriteLine();

        if (a > matrix.GetLength(0) && b > matrix.GetLength(0))
        {
         Console.WriteLine("Элемента массива с данной позицией не найдено");
        }
        else
        {
           Console.Write($"{matrix[a, b]}"); 
        }

        
        
    }

}