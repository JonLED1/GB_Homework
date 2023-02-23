// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
    Console.Write("Вы ошиблись!\nВведите трехзначное число ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(n / 10 % 10);