// Дан текст. 
// В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, 
// а большие “С” заменить маленькими “с”.


// Введем текст 

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            +"Вы так красноречивы. Вы дадите мне чаю?";
 
 // string s = "qwerty"
 //             012345
 // Индексы символом начинаются с нуля

 // s[3] это r

 string Replace(string text, char oldValue, char newValue)

// Создаем метод Replace
// Вводим в метод данные – string text, char oldValue, char newValue

{
    string result = String.Empty;
    // Создаем пустую строку

    int length = text.Length; //Определяем длину заданного текста 
    for (int i = 0; i < length; i++) 
    // Изначально индекс равен нулю и пока индекс меньше длины заданного текста 
    // выполняем действие и увеличиваем индекс на 1
    {

        if(text[i] == oldValue) result = result + $"{newValue}";
        // Пока индекс меньше длины текста – 
        // Если символ текста под индексом равнозначен! oldValue – вводимое пользователем перееменная
        // то результат равен пустой строке + newValue – вводимое пользователем перееменная

        else  result = result + $"{text[i]}";  

        // Если символ текста под индексом !НЕ равнозначен! oldValue
        // То результат равен строке + исмвол под индексом 

    }

    return result; 
    // Возвращаем результат 
}

string newText = Replace(text, ' ', '|');
// Используем метод 
// Вводим текст, char oldValue = ' ', char newValue = '|'

Console.WriteLine(newText);
// Выводим новый (измененный) текст

// Начнем обрабатывать новый текст
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);