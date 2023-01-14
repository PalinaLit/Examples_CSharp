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


    public static int NaturalNumbersOutPut (int number)
    {
        while (number > 0)
        {
            Console.WriteLine ("  " + $"{number}");
            number -= 1;
        }
        return number;
    }
}