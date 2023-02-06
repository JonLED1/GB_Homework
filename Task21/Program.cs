Console.Clear();
Console.Write("Введите координату X точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X точки В: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки В: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Результат: {l}");