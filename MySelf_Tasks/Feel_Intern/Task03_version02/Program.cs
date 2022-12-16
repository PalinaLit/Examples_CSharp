// 3. По заданному номеру дня недели вывести его название

// start

// int Monday = 1;
// int Tuesday = 2;
// int Wensday = 3;
// int Thursday = 4;
// int Friday = 5;
// int Satarday = 6;
// int Sunday = 7;

Console.WriteLine("Введине число от 1 до 7 включительно");

// Просим пользователя набрать одно из возможных чисел 
// 1 2 3 4 5 6 7 

string number = Console.ReadLine();
// Вкладываем введенные пользователем данные в хранилище "day"

int day = Convert.ToInt32(number);

if(day == 1)
{
    Console.WriteLine("Monday");
}
if(day == 2)
{
    Console.WriteLine("Tuesday");
}
if(day == 3)
{
    Console.WriteLine("Wensday");
}
if(day == 4)
{
    Console.WriteLine("Thursday");
}
if(day == 5)
{
    Console.WriteLine("Friday");
}
if(day == 6)
{
    Console.WriteLine("Satarday");
}
if(day == 7)
{
    Console.WriteLine("Sanday");
}