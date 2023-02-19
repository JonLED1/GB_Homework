void InputMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Convert.ToString(Console.ReadLine()!);
    }
}

void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}");
        Console.WriteLine();
    }
}

//Делаем правильный негатив
void NegativeMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i,j]=="w")
                matrix[i,j] = "b";
            else
                matrix[i,j] = "w";
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
string[,] matrix = new string[size[0], size[1]];
string[,] matrix2 = new string[size[0], size[1]];
InputMatrix(matrix);
InputMatrix(matrix2);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix2);
NegativeMatrix(matrix);

//проверяем правильный негатив с введенным
int count=0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i,j]!=matrix2[i,j])
                count++;
    }
Console.WriteLine();             
Console.WriteLine(count);

