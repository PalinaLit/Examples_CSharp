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

    /// <summary>
    /// Задача 27: Напишите программу, которая 
    /// принимает на вход число и выдаёт сумму цифр в числе.
    /// 452 -> 11
    /// 82 -> 10
    /// 9012 -> 12
    /// Строки использовать нельзя
    /// </summary>
    public static void Task27()
    {
        Console.WriteLine("Определим суммы цифр числа");
        Console.WriteLine();

        // 1. Принять на вход от пользователя число
        int number = UserInput("Введите число");
        Console.WriteLine();

        // 2. Определить количесво цифтр в числе
        int figure = Figure(number);

        // 3. Вывести цифра числа
        Console.WriteLine("Сумма цифр числа = "+NumberDigit(number, figure));

    }

    /// <summary>
    /// Задача 29: Напишите программу, которая задаёт
    /// массив из N элементов (из диапазона [0-14] ) 
    /// и выводит на экран десятичное представление числа, 
    /// записанного в СС по основанию 15
    /// N: 3 [9, 4, 12] => 2097
    /// </summary>
    public static void Task29()
    {
        // 1. Зададим и выведем массим из N элементов (из диапазона [0-14])
        int size = UserInput("Введите количество элементов массива");
        Console.WriteLine();
        int[] arr = CreateArray(size);
            // Указываем диапазон до 15, потому что 14 должно войти в диапазон
            // А так как метод заполнения массива через new Random().Next(a, b);
            // то последние число в отличии от первого в диапазон не входит 
        HW04_Library.FillArray(arr, 0, 15);
        Console.Write(PrintArray(arr));
        Console.WriteLine();
        Console.WriteLine();

        // 2. Переведем в СС по основанию 15
        double result = 0;
        int reverseIndex = arr.Length;
        for (int index = 0; index < reverseIndex; index++)
        {
            result += arr[index] * Math.Pow(15, reverseIndex - 1 - index);
        }
        Console.WriteLine("Десятичное представление – "+result);
 
    }

}