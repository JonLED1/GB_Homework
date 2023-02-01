Console.Clear();
Console.Write("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
    Console.Write("Вы ошиблись!\nВведите трехзначное число ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(n / 10 % 10);