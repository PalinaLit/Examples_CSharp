// 3. По заданному номеру дня недели вывести его название

// start

// int Monday = 1;
// int Tuesday = 2;
// int Wensday = 3;
// int Thursday = 4;
// int Friday = 5;
// int Satarday = 6;
// int Sunday = 7;

int random = new Random().Next(1, 8);     // Определяем рандомное число от 1 до 7 включительно 

// 1 2 3 4 5 6 7

if(random == 1)
{
    Console.WriteLine("Monday");
}
if(random == 2)
{
    Console.WriteLine("Tuesday");
}
if(random == 3)
{
    Console.WriteLine("Wensday");
}
if(random == 4)
{
    Console.WriteLine("Thursday");
}
if(random == 5)
{
    Console.WriteLine("Friday");
}
if(random == 6)
{
    Console.WriteLine("Satarday");
}
if(random == 7)
{
    Console.WriteLine("Sunday");
}

