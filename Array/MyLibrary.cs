

/// <summary>
/// Библиотека для работы с массивами
/// </summary>
public static class MyLibrary123
{
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
    /// Метод заполнения массива
    /// </summary>
    /// <param name="array">Количество элементов массива</param>
    /// <param name="min">Минимальное значенние переменых в массиве</param>
    /// <param name="max">Максимальное значение переменных в массиве</param>
    public static void Fill(int[] array, int min, int max)
    {
        int size = array.Length;
        // int index = 0; 
        //  index++;
        //  while(index < length)
        // Для замены идем через оператор for
        for (int i = 0; i < size; i++ )
        {
            // array[i] = new Random().Next(min, max);
            // Есть второй способ присваивания рандомных значений
            // Особо ничем не отличается => использовать по желанию

            array[i] = Random.Shared.Next(min, max);
        }
    }
    /// <summary>
    /// ПЛОХОЙ метод печати массива
    /// </summary>
    /// <param name="array">Имя массива для печати</param>
    public static void PrintBad(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{array[i], 3}");
        }
         Console.WriteLine();
    }
    
    /// <summary>
    /// ХОРОШИЙ метод печати массива
    /// </summary>
    /// <param name="array">Имя массива для печати</param>
    public static string PrintGood(int[] array)
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
    /// Метод считывания числа от пользователя
    /// </summary>
    /// <param name="text">Текст, который увидит пользователь</param>
    /// <returns></returns>
    public static int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    
    /// <summary>
    /// Метод нахождения количества элементов массива 
    /// по диапазону их значений
    /// </summary>
    /// <param name="array">Массив для поиска</param>
    /// <param name="min">Нижняя граница диапазона значений для поиска</param>
    /// <param name="max">Верхняя граница диапазона значений для поиска</param>
    /// <returns></returns>
    public static int Decision(int[] array, int min, int max)
    {
        int result = 0;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            if(array[i] >= min && array[i] <= max)
            {
                result++;
            }
        }
        return result;
    }

}



