// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали. 

// 3 4
// 5 9 2 6         1 2 8 7 
// 6 2 4 3         6 2 4 3 
// 1 2 8 7         5 9 2 6

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
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

int temp=0;
for (int i = 0; i < matrix.GetLength(0) / 2; i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[i,j];
        matrix[i, j] = matrix[matrix.GetLength(0)-1-i, j];
        matrix[matrix.GetLength(0)-i-1, j] = temp;
    }

}
Console.WriteLine("");
PrintMatrix(matrix);