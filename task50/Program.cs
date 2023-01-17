// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Array()
{
    int[,] array = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            array[i, j] = new Random().Next(0, 10);

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

void Zapros()
{
    Console.Write("Введите координату строки: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату столбца: ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x >= array.GetLength(0) || y >= array.GetLength(1))
        Console.WriteLine("Элемента не существет. Введите другие координаты.");
    else Console.WriteLine($"Данные ячейки: {array[x, y]}");
}
Print();
Zapros();