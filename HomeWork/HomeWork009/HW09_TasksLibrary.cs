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

    /// <summary>
    /// Задача 68: Напишите программу вычисления
    /// функции Аккермана с помощью рекурсии.
    /// Даны два неотрицательных числа m и n.
    /// m = 2, n = 3 -> A(m,n) = 9;
    /// m = 3, n = 2 -> A(m,n) = 29;
    /// </summary>
     public static void Task068()
    {
        // Если m = 0, то A(0, n) = n + 1.
        // Если m = 1, то A(1, n) = A(0, A(1, n – 1)) 
        // Если m = 2, то A(2, n) = A(1, A(2, n – 1))
        // Если m = 3, то A(3, n) = A(2, A(3, n – 1))

        // A(0, n) = n + 1,
        // A(1, n) = n + 2,
        // A(2, n) = 2n + 3,
        // A(3, n) =  2n+3 – 3
      
       
        Console.WriteLine("Вычесление функции Аккермана А(2, 3)");

        Console.WriteLine(AkkermanFunction(2, 3));

        Console.WriteLine("Вычесление функции Аккермана А(3, 2)");

        Console.WriteLine(AkkermanFunction(3, 2));

        
    }

}

