Console.Clear();
Console.Write("Введите первое число a=");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b=");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1>n2)
    Console.WriteLine($"Число a={n1} больше, чем число b={n2}");
else
    Console.WriteLine($"Число a={n1} меньше, чем число b={n2}");