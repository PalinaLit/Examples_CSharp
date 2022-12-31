using static HW05_Library;

public static class HW05Tasks_Library
{
    /// <summary>
    /// Задайте массив заполненный
    /// случайными положительными трёхзначными числами.
    /// Напишите программу, которая покажет количество чётных чисел в массиве.
    /// [345, 897, 568, 234] -> 2
    /// </summary>
    public static void Task034()
    {
        // 1. Создадим массив
        int[] array = CreateArray(5);

        // 2. Заполним массив положительными трехзнаными числами
        HW05_Library.FillArray(array, 100, 1000);

        // 3. Выведем массив в терминал 
        Console.WriteLine("Массив -> "+PrintArray(array));

        // 4. Определим четные числа в массиве и их количество 
        HW05_Library.EvenNumbers(array);
    }

    /// <summary>
    /// Задайте одномерный массив, 
    /// заполненный случайными числами. 
    /// Найдите сумму элементов, стоящих на нечётных позициях.
    /// [3, 7, 23, 12] -> 19
    /// [-4, -6, 89, 6] -> 0
    /// </summary>
    public static void Task036()
    {
        // 1. Создадим, заполним сллучайными числами одномерных массив
        // и выведем его
        int[] array = CreateArray(10);
        HW05_Library.FillArray(array, 0, 801);
        Console.WriteLine("Массив -> "+PrintArray(array));

        // 2. Определим элементы на нечетных позициях
        // 3. Найдем сумму элементов на нечетных позициях
        // 4. Выведем сумму элементов с нечетных позиций

        HW05_Library.ArrayOddIndexNumbersSum(array);

    }

    /// <summary>
    /// Задайте массив вещественных чисел. 
    /// Найдите разницу между максимальным и минимальным элементов массива.
    /// [3 7 22 2 78] -> 76
    /// </summary>
    public static void Task038()
    {
        // 1. Задать массив (вещественными числами!)
        double[] array = CreateRealNumredArray(5);

        // 2. Заполнить массив вещественными числами
        // 3. Вывести массив в консоль
        HW05_Library.FillArrayWithRealNumbers(array);
        
        Console.WriteLine();
        Console.WriteLine();

        // 3. Определим максимальный и минимальный элементы массива
        // 4. Найдем разницу между максимальным и минимальным элементом массива
        // 5. Вывести резуьтат разницы между максимальным и минимальным элемнтами массива
        HW05_Library.MinMaxArrayNumbers(array);

        

    }
}
