// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этот элемент или же указание, что такого элемента нет.
// Например, задан массив: 3 4
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-100, 100);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите позицию элемента массива: ");
int[] pos = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
if (pos[0] > matrix.GetLength(0) || pos[1] > matrix.GetLength(1))
    Console.WriteLine("Такого элемента в массиве нет");
else
    Console.WriteLine($"Элемент [{pos[0]},{pos[1]}] число {matrix[pos[0]-1, pos[1]-1]}");
