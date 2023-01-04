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
    /// Метод ввода числа от пользователя DOUBLE
    /// </summary>
    /// <param name="text">Тест, который видит пользователь
    /// перед вводом числа</param>
    /// <returns></returns>
    public static double UserNumberInputDouble(string text)
    {
        Console.WriteLine(text);
        double number = Convert.ToInt32(Console.ReadLine());
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

    /// <summary>
    /// Возведение числа в степень 
    /// </summary>
    /// <param name="number">число, которое возводим в степень</param>
    /// <param name="power">степень, в которую возводим число</param>
    /// <returns></returns>
    public static double RasingNumberToThePower(int number, int power)
    {
        double result = Math.Pow(number, power);
        return result;
    }
}