public static class Library
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
    /// Метод определения четности одного числа к другому
    /// и вывода результата
    /// </summary>
    /// <param name="number">число, четность к котору определяем</param>
    /// <param name="forMultiplicityNumber">значение, которому кратно число</param>
    public static void NumberMultiplicity(int number, int forMultiplicityNumber)
    {
        if (number % forMultiplicityNumber == 0)
        {
            Console.WriteLine(number+" is multiple of "+forMultiplicityNumber);
        }
        else
        {
            Console.WriteLine(number+" is NOT multiple of "+forMultiplicityNumber); 
        }
    }
}