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

    /// <summary>
    /// Метод определения суммы натуральных чисел в заданном промежутке
    /// </summary>
    /// <param name="min">минимальное значение в промежутке</param>
    /// <param name="max">максимальное значение в промежутке</param>
    public static void NaturalBetweenNumbersSum (int min, int max)
    {
        int result = 0;
        for (int sum = min; sum <= max; sum++ )
        {
            result += sum; 
        }
        Console.Write("Сумма натуральных чисел промежутка = "+$"{result}");


    }

    /// <summary>
    /// Функция Аккермана
    /// </summary>
    /// <param name="m">значение m</param>
    /// <param name="n">значение n</param>
    /// <returns></returns>
    public static int AkkermanFunction(int m, int n) 
    {
        // if m == 0 then A(n+1)
        // if m > 0 && n = 0 then A(m-1, 1)
        // if m > 0 && n > 0 then A(m-1, A(m, n-1))
        // Каждая А – новая рекурсия внутри рекурсии
        if (m == 0) 
        {
            return n + 1;
        } 
        else if (n == 0 && m > 0) 
        {
            return AkkermanFunction(m - 1, 1);
        } 
        else 
        {
            return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
        }
    }
    
}
      
        // A(0, n) = n + 1,
        // A(1, n) = n + 2,
        // A(2, n) = 2n + 3,
        // A(3, n) = 2n+3 – 3
     
