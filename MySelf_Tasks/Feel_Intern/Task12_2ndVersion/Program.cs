// 12. Удалить вторую цифру трёхзначного числа


string N = Convert.ToString(new Random().Next(100, 1000));
Console.WriteLine("Трехзначное число -> "+N);
Console.WriteLine("Удаляем вторую цифру трехзначного числа -> "+N.Remove(1, 1));

// Метод String.Remove удаляет указанное количество знаков, 
// начиная с указанного места в существующей строке. 
// Этот метод подразумевает, что отсчет индекса начинается с нуля.
// В следующем примере удаляется 10 символов из строки, 
// начиная с позиции 5 отсчитываемого от нуля индекса строки.

// string MyString = "Hello Beautiful World!";
// Console.WriteLine(MyString.Remove(5,10));
// The example displays the following output:
//         Hello World!