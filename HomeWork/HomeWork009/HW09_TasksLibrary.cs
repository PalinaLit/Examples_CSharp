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
        int number = UserInputIntNumber("Введите целое число");
        Console.WriteLine();
        HW09_Library.NaturalNumbersOutPut(number);
    }

}

