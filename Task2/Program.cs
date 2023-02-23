// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число a=");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b=");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1>n2)
    Console.WriteLine($"Число a={n1} больше, чем число b={n2}");
else
    Console.WriteLine($"Число a={n1} меньше, чем число b={n2}");