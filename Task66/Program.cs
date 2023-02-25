// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNum(int m, int n, int count)
{
    if (count == 0)
        return m;
    return SumNum(m+n, n-1, count-1);
}

Console.Clear();
Console.Write("Введите число 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(m, n, n-m));