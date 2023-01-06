using  static HW06_Library;

public static class TasksHW06_Library
{
    /// <summary>
    /// Задача 41: Пользователь вводит с клавиатуры M чисел. 
    /// Посчитайте, сколько чисел больше 0 ввёл пользователь.
    /// 0, 7, 8, -2, -2 -> 2; 
    /// 1, -7, 56, 89, 22-> 4;
    /// </summary>
    public static void Task041()
    {
        int[] array = CreateArray(UserNumberInput("Введите количество элементов массива"));
        
        HW06_Library.FillArray(array);
        Console.WriteLine();

        Console.WriteLine("Массив: "+ PrintArray(array));
        Console.WriteLine();

        Console.WriteLine("Количество элементов в массиве больше нуля -> "+ArrayFiguresUpperNumber(array, 0));

    }

    /// <summary>
    /// Задача 43: Напишите программу, которая найдёт точку 
    /// пересечения двух прямых, заданных уравнениями 
    /// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    /// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    /// </summary>
    public static void Task043()
    {
        // y = k1 * x + b1      y = 5x + 2
        // y = k2 * x + b2      y = 9x + 4

        // Вычтем из первого уравнения второе
        // k1x + b1 = k2x + b2
        // k1x - k2x = b2 - b1
        // x(k1-k2) = b2 - b1
        // x = (b2-b1)/(k1-k2)
        // ! этот x – первая точка !


        Console.WriteLine("Найдём точку пересечения двух прямых, заданных уравнениями: ");
        Console.WriteLine();
        Console.WriteLine("Уравнение 1: y = k1 * x + b1");
        double b1 = UserNumberInputDOUBLE("Введите значение b1 для заданного уравнения");
        double k1 = UserNumberInputDOUBLE("Введите значение k1 для заданного уравнения");

        Console.WriteLine();
        Console.WriteLine("Уравнение 2: y = k2 * x + b2");
        double b2 = UserNumberInputDOUBLE("Введите значение b2 для заданного уравнения");
        double k2 = UserNumberInputDOUBLE("Введите значение k2 для заданного уравнения");

        Console.WriteLine(CoordinatePointIntersection(k1, b1, k2, b2));
        
    }
    





}
