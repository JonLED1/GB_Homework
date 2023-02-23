//  Миша уже научился хорошо фотографировать и недавно увлекся программированием. Первая программа, которую он написал, позволяет формировать негатив бинарного черно-белого изображения.
// Бинарное черно-белое изображение – это прямоугольник, состоящий из пикселей, каждый из которых может быть либо черным, либо белым.
// Негатив такого изображения получается путем замены каждого черного пикселя на белый, а каждого белого пикселя – на черный.
// Миша, как начинающий программист, написал свою программу с ошибкой, поэтому в результате ее исполнения мог получаться некорректный негатив.
// Для того чтобы оценить уровень несоответствия получаемого негатива исходному изображению, Миша начал тестировать свою программу.
// В качестве входных данных он использовал исходные изображения. Сформированные программой негативы он начал тщательно анализировать,
//  каждый раз определяя число пикселей негатива, которые получены с ошибкой.
// Требуется написать программу, которая в качестве входных данных использует исходное бинарное черно-белое изображение и полученный Мишиной программой негатив,
//  и на основе этого определяет количество пикселей, в которых допущена ошибка. 
// 3 4             2
// WBBW
// BBBB
// WBBW

// BWWW
// WWWB
// BWWB

// 2 2   2
// BW
// BB

// WW
// BW

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

