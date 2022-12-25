public static class HW03_Library
{
    /// <summary>
    /// Метод ввода юзером целого числа
    /// </summary>
    /// <param name="text">Текст для пользователем перед вводом</param>
    public static int UserInput(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    /// <summary>
    /// Выведение цифр числа в обратном поряде (число наоборот)
    /// </summary>
    /// <param name="number">Первоначально число</param>
    public static int BackNumber(int number)
    {
        //Введем переменную в которую будем сохранять обратное число
        int backNumber = 0;
        while (number > 0)
        {
            // Через number % 10 получаем остаток от деления 
            // Например при изначальном числе 123 – остаток "3"
            // Условно говоря – поcледняя цифра числа
            backNumber = backNumber * 10 + number % 10; 
            // умножаем изначальное и последующие backNumber на 10
            // для того, чтобы они стали на десяток (разряд) выше и стояли перед следующим остатком в новой цифре 
            // То есть повышаем backNumber с единиц до десятком, сотен и т.д. 
            
            number = number / 10;
            // В свою очередь основное число понижаем через деление на 10 без остатка 
            // То есть если изначальное число 1234
            // через действие 1234 /= 10 мы получим 123 (123 полных десятка в числе)
        }
        return backNumber;
        // Возвращаем backNumber ВНЕ ЦИКЛА WHILE!!! 
    }   

    /// <summary>
    /// Метод, который принимает на вход координаты двух точек 
    /// и находит расстояние между ними в 2D пространстве.
    /// </summary>
    /// <param name="xa">Координата х первой точки</param>
    /// <param name="ya">Координата y первой точки</param>
    /// <param name="xb">Координата х второй точки</param>
    /// <param name="yb">Координата y второй точки</param>
    /// <returns></returns>
    public static double DistanceXYPoints(int xa, int ya, int xb, int yb)
    {
        double distance = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2));
        return distance;
    }
}


