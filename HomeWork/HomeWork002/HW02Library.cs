/// <summary>
/// Библиотека для методов к ДЗ №2
/// </summary>
public static class HW02Library
{
    /// <summary>
    /// Метод для ввода пользователем целого числа
    /// </summary>
    /// <param name="text">Текст, который видит пользователь перед вводом</param>
    /// <returns></returns>
    public static int NumberInput(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    /// <summary>
    /// Метод преобразования числа в cтроку
    /// </summary>
    /// <param name="numberToConvert">Число, которое будет преобразовываться в строку</param>
    /// <returns></returns>
    public static string stringNumber(int numberToConvert)
     {
        string number = Convert.ToString(numberToConvert);
        Console.WriteLine("Ваше число -> "+number);
        return number;
     }

   
    /// <summary>
    /// Метод вывода определнного по счету символа в строке
    /// </summary>
    /// <param name="index">Индекс символа, который хотим вывести</param>
    /// <param name="stringToSymbol">Строка из которой происходит вывод симбола</param>
    /// <returns></returns>
     public static string SymbolNumber(int index, string stringToSymbol)
     {
        string symbol = String.Empty;
        symbol += $"{stringToSymbol[index]}";
        return symbol;
     }

    /// <summary>
    /// Метод вывода строки
    /// </summary>
    /// <param name="text">Текст для юзера перед выводом результата</param>
    /// <param name="StringSymbol">строка, которую выводим</param>
     public static string Printout(string text, string StringSymbol)
     {
        string symbol = string.Empty;
        symbol += $"{text+StringSymbol}";
        return symbol;
     }

}






