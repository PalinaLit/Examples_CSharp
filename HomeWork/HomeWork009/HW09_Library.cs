public static class HW09_Library
{
    // <summary>
    /// Метод ввода целого числа от пользователя
    /// </summary>
    /// <param name="text">текс, который видит юзер перед вводом числа</param>
    /// <returns></returns>
    public static int UserInputIntNumber(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    /// <summary>
    /// Метод определения натуральный чисел от минимального числа 
    /// до заданного числа
    /// </summary>
    /// <param name="number">заданное число</param>
    /// <param name="min">минимальное число промежутка</param>
    /// <returns></returns>
    public static int NaturalNumbersOutPut (int number, int min)
    {
        while (number >= min && number != 0)
        {
            Console.WriteLine ("  " + $"{number}");
            number -= 1;
        }
        return number;
    }

    public static void NaturalBetweenNumbersSum (int min, int max)
    {
        int result = 0;
        for (int sum = min; sum <= max; sum++ )
        {
            result += sum; 
        }
        Console.Write("Сумма натуральных чисел промежутка = "+$"{result}");


    }
}