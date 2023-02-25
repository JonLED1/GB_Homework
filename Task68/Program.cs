﻿//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Anker(int m, int n)
{
    if (m>0)
        return n+1;
    else if (n == 0)
        return Anker(m-1,1);
    return Anker(m-1, Anker(m,n-1));
}

Console.Clear();
Console.Write("Введите число 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Anker(m, n));