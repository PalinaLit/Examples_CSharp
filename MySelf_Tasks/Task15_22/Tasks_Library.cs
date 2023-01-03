using static Library;

public static class Tasks_Library
{
    /// <summary>
    /// 15. Дано число. Проверить кратно ли оно 7 и 23
    /// </summary>
    public static void Task15()
    {
        int userNumber = UserNumberInput("Input any integer number");
        Library.NumberMultiplicity(userNumber, 7);
        Library.NumberMultiplicity(userNumber, 23);
    }

    /// <summary>
    /// 16. Дано число обозначающее день недели. 
    /// Выяснить является номер дня недели выходным 
    /// </summary>
    public static void Task16()
    {
        int monday = UserNumberInput("What number will be for Monday?");
        int tuesday = UserNumberInput("What number will be for Tuesday?");
        int wensday = UserNumberInput("What number will be for Wensday?");
        int thursday = UserNumberInput("What number will be for Thursday?");
        int friday = UserNumberInput("What number will be for Friday?");
        int saturday = UserNumberInput("What number will be for Saturday?");
        int sunday = UserNumberInput("What number will be for Sunday?");

        Console.WriteLine();
        Console.WriteLine();

        int userDayNumber = UserNumberInput("Input any day' number");

        if (userDayNumber == saturday)
        {
            Console.WriteLine("This is weekend!");
        }
        else if (userDayNumber == sunday)
        {
            Console.WriteLine("This is weekend!");
        }
        else
        {
            Console.WriteLine("This is NOT weekend!");
        }
    }

    /// <summary>
    /// 17. По двум заданным числам проверять 
    /// является ли одно квадратом другого
    /// </summary>
    public static void Task17()
    {
        double number = UserNumberInputDouble("Input 1th integer number");
        int numberSquare = UserNumberInput("Input 2nd integer number");

        Console.WriteLine();

        double square = RasingNumberToThePower(numberSquare, 2);
        if (number == square)
        {
            Console.WriteLine("The number "+square+" is the square of number "+number);
        }
        else
        {
            Console.WriteLine("The number "+square+" is NOT the square of number "+number);
        }


        
    }

}


