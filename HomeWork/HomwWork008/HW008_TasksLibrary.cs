
using static Hw008_Library;

public static class HW008_TasksLibrary
{

    /// <summary>
    /// Задача 54: Задайте двумерный массив. 
    /// Напишите программу, которая упорядочит 
    /// по убыванию элементы каждой строки двумерного массива.
    /// Например, задан массив:
    /// 1 4 7 2;
    /// 5 9 2 3;
    /// 8 4 2 4;
    /// В итоге получается вот такой массив:
    /// 7 4 2 1;
    /// 9 5 3 2;
    /// 8 4 4 2;
    /// </summary>
    public static void Task054()
    {
        int[,] matrix = new int [3, 4];
        PrintMatrixInt(matrix);

        Console.WriteLine();

        FillMatrixInt(matrix);
        PrintMatrixInt(matrix);
        Console.WriteLine();

        AscendingMatrixStringNumbers(matrix);
        PrintMatrixInt(matrix);
        Console.WriteLine();

    }
    
}


