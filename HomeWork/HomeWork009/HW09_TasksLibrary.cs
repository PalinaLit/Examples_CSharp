using static HW09_Library;

public static class HW009_TasksLibrary
{
    /// <summary>
    /// Задача 64: Задайте значение N. Напишите программу,
    /// которая выведет все натуральные числа в промежутке от N до 1. 
    /// Выполнить с помощью рекурсии.
    /// N = 5 -> "5, 4, 3, 2, 1" ;
    /// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    /// </summary>
    public static void Task064()
    {
        int number = UserInputIntNumber("Введите натуральное число");
        Console.WriteLine();
        HW09_Library.NaturalNumbersOutPut(number, 0);
    }

    /// <summary>
    /// Задача 66: Задайте значения M и N. 
    /// Напишите программу, которая найдёт сумму натуральных 
    /// элементов в промежутке от M до N.
    /// M = 1; N = 15 -> 120
    /// M = 4; N = 8. -> 30
    /// </summary>
    public static void Task066()
    {
        Console.WriteLine("Задан промежуток от M до N");
        Console.WriteLine();
        int M = UserInputIntNumber("Введите натуральное число для М");
        int N = UserInputIntNumber("Введите натуральное число для N");
        Console.WriteLine();
        
        HW09_Library.NaturalBetweenNumbersSum(M, N);

        
    }

}

