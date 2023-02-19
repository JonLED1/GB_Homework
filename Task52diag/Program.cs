void InputMatrix(int[,] matrix)
{
    //заполняем первый элемент
    int count = 0;
    matrix[0, 0] = count;
    count++;
    // перебераем верхнюю строку, с заполнением диагоналей вниз-влево
    for (int j = 1; j < matrix.GetLength(1); j++) 
    {
        matrix[0, j] = count;
        count++;
        int k = 1;
        int z = j-1;
        while (z >= 0)
        {   
            Console.WriteLine($"[{k},{z}]");
            matrix[k, z] = count;
            count++;
            k++;
            z--;
            
            
        }
        Console.WriteLine("______________");
       

    }
    // перебераем нижнюю строку, с заполнением диагоналей вверх-вправо
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

//Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

