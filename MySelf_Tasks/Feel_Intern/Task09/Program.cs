﻿ // 9. Показать последнюю цифру трёхзначного числа

// start

// 1. Принимаем на вход целое число от пользователя | трехзначное

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

// 2. Преобразуем число в строку для вывода опредленного символа по порядку
string N = Convert.ToString(number);
Console.WriteLine("Ваше число -> "+N);

// 3. Выводи третью цифру трехзначного числа 
// => символ строки под индексом [2]
Console.WriteLine("Третья цифра вашего числа -> "+N[2]);

// end