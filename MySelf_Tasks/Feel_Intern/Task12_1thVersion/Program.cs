// 12. Удалить вторую цифру трёхзначного числа

// Console.WriteLine("Введите трехзначное число");
// int N = Convert.ToInt32(Console.ReadLine());

// int N = new Random().Next(100, 1000);

string number = Convert.ToString(new Random().Next(100, 1000));
Console.WriteLine(number);
Console.WriteLine("Удаляем вторую цифру трехначного числа -> "+number[0]+number[2]);


