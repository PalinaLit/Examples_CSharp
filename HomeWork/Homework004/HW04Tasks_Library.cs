using static HW04_Library;
public static class HW04Tasks_Library

{
    /// <summary>
    /// Напишите цикл, который принимает на вход два числа (A и B) 
    /// и возводит число A в натуральную степень B.
    /// 3, 5 -> 243 (3⁵)
    /// 2, 4 -> 16
    /// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow
    /// </summary>
    public static void Task25()
    {
        // 1. Принять на вход от пользователя 2 числа
        int A = UserInput("Введите первое число");
        int B = UserInput("Введите второе число");

        Console.WriteLine("Возведем первое число в натуральную степень второго");
        // 2. Возвести певрое число в натуральную степень второго
        // НАПИСАТЬ ЦИКЛ!
        int i = 0;
        int result = 1;
        while(i < B)
        {
            result = result * A;
            i++;
        }

        Console.WriteLine(result);

    }


}