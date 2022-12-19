// 8. Показать четные числа от 1 до N

// start

Console.WriteLine("Введите любое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Четные числа от 1 до "+N);

int number = 1;

while(number < N)
{
    if(0 == number % 2)
    {
        Console.WriteLine(number);
    }
    number++;
}

// end
