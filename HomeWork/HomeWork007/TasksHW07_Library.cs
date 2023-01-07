using static HW07_Library;

public static class TasksHW07_Library
{
    /// <summary>
    ///  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    /// m = 3, n = 4.
    /// 0,5 7 -2 -0,2;
    /// 1 -3,3 8 -9,9;
    /// 8 7,8 -7,1 9;
    /// </summary>
    public static void Task047()
    {
    
        double[,] matrix = new double[3, 4];
        PrintArrayDouble(matrix); 

        Console.WriteLine();

        FillArrayDouble(matrix);
        PrintArrayDouble(matrix);
       
    }


    /// <summary>
    /// Задача 50. Напишите программу, которая на вход принимает 
    /// позиции элемента в двумерном массиве, и возвращает значение 
    /// этого элемента или же указание, что такого элемента нет.
    /// Например, задан массив:
    /// 1 4 7 2
    /// 5 9 2 3
    /// 8 4 2 4
    /// 17 -> такого числа в массиве нет
    /// </summary>
    public static void Task050()
    {
        int[,] matrix = new int [3, 4];
        PrintArrayInt(matrix);

        Console.WriteLine();

        FillArrayInt(matrix);
        PrintArrayInt(matrix);

        
    }
}