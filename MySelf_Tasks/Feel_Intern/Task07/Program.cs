//  7. Показать числа от -N до N


// start

Console.WriteLine("Введите целое число N");
string UserNumber = Console.ReadLine();
int N = Convert.ToInt32(UserNumber);

Console.WriteLine();

int Negative = -N;

while(Negative < N)
{
    Console.WriteLine(Negative);
    Negative++;
}
Console.WriteLine(Negative);

//end
