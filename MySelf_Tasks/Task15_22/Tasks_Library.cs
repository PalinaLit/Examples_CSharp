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

}


