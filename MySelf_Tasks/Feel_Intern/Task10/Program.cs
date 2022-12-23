// 10. Показать вторую цифру трёхзначного числа

Console.WriteLine("Input threedigit number");
int userNumber = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(userNumber);
Console.WriteLine("Your number's second figure -> "+number[1]);
