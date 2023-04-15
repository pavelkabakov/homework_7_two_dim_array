// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] table = new int[5, 8];

FillArray(table);
PrintArray(table);

// Вводим два числа
Console.Write("Введите номер строки элемента массива - ");
int elementsRow = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца элемента массива - ");
int elementsColumns = int.Parse(Console.ReadLine());
PrintArrayElement(elementsRow, elementsColumns, table);

// вывод значения элемента массива
void PrintArrayElement (int elementsRow, int elementsColumns, int[,] tab)
{
    if (ValidateValue(elementsRow, elementsColumns, tab))
    {
        Console.WriteLine($"Значение элемента массива = {tab[elementsRow, elementsColumns]}");
    }
}
// проверка значений на вхождение в диапазон массива
bool ValidateValue (int elementsRow, int elementsColumns, int[,] tab)
{
    if (elementsRow < 0 | elementsRow >= tab.GetLength(0) || 
        elementsColumns < 0 | elementsColumns >= tab.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
        return false;
    }
    return true;
}
// вывод массива
void PrintArray(int[,] tab) 
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    Console.Write($"строка {rows} - ");
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        Console.Write($" '{table[rows, columns]}'");
    }
Console.WriteLine();
}
}
// заполнение массива случайными числами
void FillArray(int[,] tab)
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        tab[rows, columns] = new Random().Next(-10, 10);
    }
Console.WriteLine();
}
}