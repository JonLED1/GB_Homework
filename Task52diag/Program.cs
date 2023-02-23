//Напишите программу заполнения массива по диаганолям
// 0       1       3       6       9  
// 2       4       7       10      12 
// 5       8       11      13      14 

void InputMatrix(int[,] matrix)
{
    int countNumb = 0;
    int countDiag = matrix.GetLength(0) + matrix.GetLength(1);
    for (int k = 0; k < countDiag; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (i + j == k)
                {
                    matrix[i, j] = countNumb;
                    countNumb++;
                }
        }

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