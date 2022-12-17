// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

// 1. Установить счетчик index в позицию 0
// 2. Если array [index] = find, алгоритм завершил работу успешно.
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.


// Заполняем массив
void FillArray(int[] collection) 
{
    int length = collection.Length; 
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// Выводим массив
void PrintArray (int[] col) 
{
    int count = col.Length;
    int position = 0; 

    while(position < count)
    {
        Console.WriteLine(col[position]); 
        position++;
    } 
}

// Для нахождения индекса элемента массива, который равен find
// Вводим массив IndexOf с аргументом collection и ЭЛЕМЕНТ МАССИВА find 
int IndexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while(index < count)
    {
        // Если элемент массива под номером index 
        // соответсвует элементу массива find
        if(collection[index] == find) 
        {
            position = index; 
            break;
        }
        index++;
    }
    return position; 
    // Возвращаем position, которой присвоили значение
    // индекса элемента массива find

}

int []array = new int [10]; 


FillArray(array);
PrintArray(array);

// Пропускаем строчки, чтобы разделить массив и индекс (позицию)
Console.WriteLine();
Console.WriteLine();

int pos = IndexOf(array, 4);
// в переменную pos вкладываем сгенерированные элементы array и 4
// По сути find == 4

Console.WriteLine(pos);