﻿Console.Clear();
Console.WriteLine("Введите любые числа, 0-признак окончания ввода ");
int n=1;
int max=n; //максимальное число
int max2=n; //второй максимум

while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max) {max2=max; max=n;}
    else if (n > max2) max2=n;   
}

Console.WriteLine($"Первый максимум - {max}");
Console.WriteLine($"Второй максимум - {max2}");