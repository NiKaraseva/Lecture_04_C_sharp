// Пример 1 (со строками)

/* string[,] table = new string[2, 5]; // 2 строчки и 5 столбцов
// String.Empty – инициализация строк 
// table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4] – индексы меняются от 0 до 4 (так как 5 элементов и начинаем мы с 0)
// table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]
table[1, 2] = "слово"; // обращаемся к определённому эл-ту, который находится на 1ой строчке во 2ом столбце

for(int rows = 0; rows < 2; rows++) // цикл с количеством строк
{
    for(int columns = 0; columns < 5; columns++) // цикл с количеством столбцов
    {
        Console.WriteLine($"-{table[rows, columns]}-"); // печатаем нашу таблицу, обращаясь к индексу строки и столбца 
    } 
}  */ 


// Пример 2 (с числами)


void PrintArray(int[,] matr)
{
  for(int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) всегда вместо 3
    {
        for(int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) всегда вместо 4
            {
                Console.Write($"{matr[i, j]} "); 
            }
    Console.WriteLine(); // вывели пустую строку, чтобы был красивый вид, как матрица
    }  
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // получается от [1, 10)
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);