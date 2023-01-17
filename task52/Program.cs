// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int n = new Random().Next(3, 10);

int[,] Array()
{
    int[,] array = new int[new Random().Next(3, 4), n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] array = Array();

void Print()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double SredArifm(int x)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == x)
                result = (result + Convert.ToDouble(array[i, j]));
        }
    }
    result = result / Convert.ToDouble(n);
    return Math.Round(result, 1); 
}

void Itog()
{
    for (int k = 0; k < n; k++)
        Console.WriteLine($"Среднее арифмитическое столбца {k + 1}: {SredArifm(k)}");
}

Print();
Itog();