// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Веедите число чисел ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i=1; i<=n; i++)
{
    Console.Write($"Веедите число номер {i} - ");
    if (Convert.ToInt32(Console.ReadLine())>0)
        count++;
}

Console.WriteLine($"чисел больше 0 - {count}");
