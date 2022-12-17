// Задача о том, как взять метод и передать в него массив + заполнить массив нужным количесвом элементов 

// void Используется как оператор языка C#
// Когда метод не должен возвращать нам значение 
// СЛЕДОВАТЕЛЬНО на НЕ НУЖЕН оператор RETURN !!!

void FillArray(int[] collection) // Создаем массив Array с аргументом collection
{
    int length = collection.Length; // Определяем длину массива в переменную length
    int index = 0;
    while(index < length)
    {
        // Пока значение индекса не превышает длину массива 
        // Делай – присвоить значение эллементу массива 
        // Делай – index++
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col) // Создаем новый массив с аргументов col
{
    int count = col.Length;
    int position = 0; 

    while(position < count)
    {
        // Пока номер элемента массива не превышает его длину
        // Делай – вывод элемента массива в терминал
        // Делай – position++
        Console.WriteLine(col[position]); 
        position++;
    }
    
}

int []array = new int [10]; 
// Создание массива с десятью переменными внутри 
// Притакой комманде массив заполняется НУЛЯМИ


FillArray(array);
PrintArray(array);




