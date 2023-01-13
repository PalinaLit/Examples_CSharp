
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

    /// <summary>
    /// Задача 56: Задайте прямоугольный двумерный массив. 
    /// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    /// Например, задан массив:
    /// 1 4 7 2
    /// 5 9 2 3
    /// 8 4 2 4
    /// 5 2 6 7
    /// Программа считает сумму элементов в каждой строке 
    /// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

    /// </summary>
    public static void Task056()
    {
        int[,] matrix = new int [4, 4];

        Console.WriteLine();

        FillMatrixInt(matrix);
        PrintMatrixInt(matrix);
        Console.WriteLine();

        MatrixLineElementSum(matrix);
    }

    /// <summary>
    /// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
    /// Напишите программу, которая будет построчно выводить массив, 
    /// добавляя индексы каждого элемента.
    /// Массив размером 2 x 2 x 2
    /// 66(0,0,0) 25(0,1,0);
    /// 34(1,0,0) 41(1,1,0);
    /// 27(0,0,1) 90(0,1,1);
    /// 26(1,0,1) 55(1,1,1);
    /// </summary>
     public static void Task060()
     {
        int[,,] matrix3D = new int [2, 2, 2];
        CreatMatrix3D(matrix3D);
        Print3DMatrix(matrix3D);
     }

    
}


