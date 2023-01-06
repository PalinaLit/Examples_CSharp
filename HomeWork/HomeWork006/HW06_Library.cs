public static class HW06_Library
{
    /// <summary>
    /// Метод ввода числа от пользователя
    /// </summary>
    /// <param name="text">Тест, который видит пользователь
    /// перед вводом числа</param>
    /// <returns></returns>
    public static int UserNumberInput(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="count">Количество элементов нового массива</param>
    /// <returns>Созданный массив из count элементов</returns>
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }

    /// <summary>
    /// Метод заполнения массива пользователем
    /// (с клавиатуры)
    /// </summary>
    /// <param name="array">Название (имя) массива</param>
    /// <param name="min">Минимальное значенние переменых в массиве</param>
    /// <param name="max">Максимальное значение переменных в массиве + 1</param>
    public static void FillArray(int[] array)
    {
        int size = array.Length;
        
        for (int i = 0; i < size; i++)
        {
            array[i] = UserNumberInput("Введите элемент массива за индексом [" + i + "]");
        }
    }

    /// <summary>
    /// Метод печати массива
    /// </summary>
    /// <param name="array">Имя массива для печати</param>
    public static string PrintArray(int[] array)
    {
        string output = String.Empty;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            output += $"{array[i], 3}";
        }
        return output;
    }

    /// <summary>
    /// Метод нахождения количества элементов массива 
    /// больше любого целого числа
    /// </summary>
    /// <param name="array">Массив для поиска</param>
    /// <param name="min">Целое число от которого начинается поиск 
    /// (минимальное значение искомых элементов)</param>
    /// <returns></returns>
    public static int ArrayFiguresUpperNumber(int[] array, int min)
    {
        int result = 0;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            if(array[i] > min)
            {
                result++;
            }
        }
        return result;
    }

    /// <summary>
    /// Метод ввода числа от пользователя DOUBLE
    /// </summary>
    /// <param name="text">Тест, который видит пользователь
    /// перед вводом числа</param>
    /// <returns></returns>
    public static double UserNumberInputDOUBLE(string text)
    {
        Console.WriteLine(text);
        double number = Convert.ToDouble(Console.ReadLine());
        return number;
    }

    /// <summary>
    /// y = k1 * x + b1;    
    /// y = k2 * x + b2;    
    /// Вычтем из первого уравнения второе: 
    ///  k1x + b1 = k2x + b2;
    ///  k1x - k2x = b2 - b1;
    ///  x(k1-k2) = b2 - b1;
    ///  x = (b2-b1)/(k1-k2);
    ///  ! этот x – первая точка !
    /// </summary>
    /// <param name="k1">y = k1 * x + b1</param>
    /// <param name="b1">y = k1 * x + b1</param>
    /// <param name="k2">y = k2 * x + b2</param>
    /// <param name="b2">y = k2 * x + b2</param>
    /// <returns></returns>
    public static string CoordinatePointIntersection (double k1, double b1, double k2, double b2)
    // string Для вывода! 
    {
        string result = String.Empty;
        // Пустая строка!!!

        double firstX = (b2 - b1) / (k1 - k2);
        double secondX = k2 * firstX + b2;
        
        result = $"[{Math.Round(firstX, 2)}, {Math.Round(secondX, 2)}]";

        return result;

    }
    
}