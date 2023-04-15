// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] table = new int[3, 4];

FillArray(table);
PrintArray(table);
ColumnsArithmeticMean(table);

// вычисление среднего арифметического для двумерного массива 
void ColumnsArithmeticMean(int [,] tab)
{
for (int rows = 0; rows < tab.GetLength(1); rows++)
{
    Console.WriteLine($"Среднее арифметическое для столбца {rows} = {Math.Round(ArithmeticMean(table, rows),2)}");
}
}

// вычисление среднего арифметического для столбца двумерного массива
double ArithmeticMean(int [,] tab, int columns)
{
    double summ = 0;
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
            summ += tab[rows, columns];
    }
    return summ/tab.GetLength(0);
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