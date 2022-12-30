
using static RecursiaLibrary;

int[,] matrix = new int[3, 4];
PrintArray(matrix); 

Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);


// string[,] table = new string [2, 5];

// Для обращения к нужному элементу:
// указываем названием массива и в [] сначала идекс строки и после индекс столбца 

//По умолчанию все строки инициализируются пустой строкой !!!

// table[1, 2] = "слово";

// Далее можем работать как обычно – бужто с обычной переменной 

// Индексы для строк и стобцов массива меняются от нуля:
//  Как будут выглядеть индексы элемннтов массива для данного примера 
// table [0, 0]     table [0, 1]        table [0, 2]        table [0, 3]        table [0, 4]
// table [1, 0]     table [1, 1]        table [1, 2]        table [1, 3]        table [1, 4] 

// for (int rows = 0; rows < 2; rows++)
// {
//     for(int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }


// int[,] matrix = new int[3, 4];

// for(int rows = 0; rows < 3; rows++)
// {
//     for(int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[rows, j]} ");
//     }
// Console.WriteLine();
// }

// Для того, чтобы не прописывать внутри циклов 
// кол-во строк и стобцов и есои что менять числа 
// только в заданном массиве:
// Внутри цикла пользуемся новым функционалом:

// строки matrix.GetLength(0)
// столбцы matrix.GetLength(1)



