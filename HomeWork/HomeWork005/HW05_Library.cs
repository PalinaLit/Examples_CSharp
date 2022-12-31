public static class HW05_Library
{
    /// <summary>
    /// Метод создания массива 
    /// </summary>
    /// <param name="size">количество аргументов массива</param>
    /// <returns></returns>
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }

    /// <summary>
    /// Метод заполнения массива
    /// </summary>
    /// <param name="array">Имя массива, который заполняем</param>
    /// <param name="min">минимальное значение аргумента для этого массива</param>
    /// <param name="max">максимальное значение аргумента для этого массива</param>
    public static void FillArray(int[] array, int min, int max)
    {
        int size = array.Length;
        for (int index = 0; index < size; index++)
        {
            array[index] = new Random().Next(min, max);
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
            output += $"{array[i]}  ";
        }
        return output;
    }

    /// <summary>
    /// Метод определения четных чисел в массиве 
    /// и вывода их количества 
    /// </summary>
    /// <param name="array">Имя массива, в котором считаем четные числа</param>
    public static void EvenNumbers (int[] array)
    {
        int size = array.Length;
        int i = 0;
        int evenNumbersCount = 0;
        while (i < size)
        {
            if (array[i] % 2 == 0)
            {
                evenNumbersCount++;
            } 
            i++;
        }
        Console.WriteLine("Количество четных чисел в массиве -> "+Convert.ToString(evenNumbersCount));
    }

    public static void ArrayOddIndexNumbersSum (int[] array)
    {
        int size = array.Length;
        int sum = 0;
        for( int i = 0; i < size; i++)
        {
            if (i % 2 == 1)
            {
                sum = sum + array[i];
            }
        }  
        Console.WriteLine("Сумма элементов с нечетным индексом -> "+Convert.ToString(sum));      

    }

}