// 14. Найти третью цифру числа или сообщить, что её нет

// 1. Ввести число от юзера 
Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());

// 2. Вывести третью цифру числа

if (number / 100 < 1)
{
    Console.WriteLine("Третьей цифры в числе нет");
    
}
// 3. Сообщить, что третьей цифры числа нет – если ее нет ;)
else
{
    string newNumber = Convert.ToString(number);
    Console.WriteLine("Третья цифра вашего числа -> "+newNumber[2]);
}

