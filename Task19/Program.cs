﻿Console.Clear();
Console.WriteLine("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
    Console.Write("Вы ошиблись!\nВведите трехзначное число ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n / 10000 == n % 10 && n / 1000 % 10 == n % 100 / 10)
    Console.WriteLine($"{n} - полиндром");
else
    Console.WriteLine($"{n} - не полиндром");