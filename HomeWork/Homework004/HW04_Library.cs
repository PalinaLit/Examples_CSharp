public static class HW04_Library
{
    /// <summary>
    /// Метод ввода целого числа от пользователя
    /// </summary>
    /// <param name="text">текс, который видит юзер перед вводом числа</param>
    /// <returns></returns>
    public static int UserInput(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    /// <summary>
    /// Метод нахождения количества цифр в числе
    /// </summary>
    /// <param name="N">Число, количество цифр которого определяем</param>
    /// <returns></returns>
    public static int Figure(int N)
    {
        int i = 0;
        while (N > 0)
        {
            i++;
            N /= 10;
        }
        Console.WriteLine("Количество цифр в числе -> "+i);
        return i;
    }

    /// <summary>
    /// Метод вывода цифр числа и их суммы 
    /// </summary>
    /// <param name="number">число, цифры которого выводим и суммируем</param>
    /// <param name="figure">количество цифр в числе</param>
    /// <returns></returns>
    public static int NumberDigit(int number, int figure)
    {
        int i = 0;
        int sum = 0;

        while (i < figure)
        {
            int a = number % 10;
            Console.WriteLine(i+" цифра числа -> "+a);
            i++;
            number = number / 10;
            sum = sum + a;
        }
        Console.WriteLine();
        return sum;

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
    /// Метод заполнения массива
    /// </summary>
    /// <param name="array">Название массива</param>
    /// <param name="min">Минимальное значенние переменых в массиве</param>
    /// <param name="max">Максимальное значение переменных в массиве + 1</param>
    public static void FillArray(int[] array, int min, int max)
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

}




