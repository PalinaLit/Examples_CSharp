using static HW03_Library;


public static class HW03Tasks_Library
{
    /// <summary>
    /// ВЕРСИЯ 1
    /// Напишите программу, которая принимает на вход пятизначное число 
    /// и проверяет, является ли оно палиндромом.
    /// 14212 -> нет;
    /// 12821 -> да;
    /// 23432 -> да;
    /// </summary>
    public static void Task19()
    {
        // 1. Метод ввода пользователем пятизначного числа
        int number = UserInput("Введите пятизначное число");

        // 2. Можно сравнить первую цифру и посленюю через деление
        // НО! подойдет только если заранее знаем сколько цифр в числе

        // a b c d e

        int a = number / 10000;
        int e = number % 10;
        int b = number / 1000 % 10;
        int d = number / 10 % 10;
        
        if (a == e && b == d)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("НЕ палиндром");
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    

    /// <summary>
    /// ВЕРСИЯ 2
    /// Напишите программу, которая принимает на вход пятизначное число 
    /// и проверяет, является ли оно палиндромом.
    /// 14212 -> нет;
    /// 12821 -> да;
    /// 23432 -> да;
    /// СТРОКИ ИСПОЛЬЗОВАТЬ НЕЛЬЗЯ !
    /// </summary>
    public static void Task19ver2()
    {
        // 1. Метод ввода пользователем пятизначного числа
        int number = UserInput("Введите пятизначное число");

        // 2. Вывод обратного числа (перевернуть число пользователя задом на перед)
        int flopNumber = BackNumber(number);

        // 3. Сравнить число пользователя и обратное число 
        // Если они равны => Вывести, что число является палиндромом
        // Если числа НЕравны => Вывести, что число пользователя НЕ палиндром

        if(number == flopNumber)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("НЕ палиндром");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    /// <summary>
    /// Напишите программу, которая принимает на вход координаты двух точек 
    /// и находит расстояние между ними в 2D пространстве.
    /// A (0,0); B (1,1), -> ~1.4;  
    /// A (2,4); B (0,7) -> ~3.6;   
    /// </summary>
    public static void Task21()
    {

        Console.WriteLine(DistanceXYPoints(2, 0, 4, 7));
        
        Console.WriteLine();
        Console.WriteLine();
    }
    
    
    /// <summary>
    /// Напишите программу, которая принимает на вход число (N) 
    /// и выдаёт таблицу кубов чисел от 1 до N.
    /// 3 -> 1, 8, 27;
    /// 5 -> 1, 8, 27, 64, 125;
    /// </summary>
    public static void Task23()
    {
        // 1. Метод ввода пользователем пятизначного числа
        int N = UserInput("Введите целое число");
        Console.WriteLine();
        

        // 2. Возвести каждое число от 1 до N в куб 

        for(int cubeNumber = 1; cubeNumber <= N; cubeNumber++)
        {
            double result = Math.Pow(cubeNumber, 3);
            Console.WriteLine(result);
        }
        
        
    }


}





