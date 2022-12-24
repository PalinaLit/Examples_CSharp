// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Задайте число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = new Random().Next(0, 1000);
Console.WriteLine("Число от программы -> "+secondNumber);

if(0 == secondNumber % firstNumber)
{
    Console.WriteLine("Число кратно заданному");
}
else
{
    int a = secondNumber % firstNumber;
    Console.WriteLine("Остаток от деления числа программы на число заданное юзером -> "+a);
}

