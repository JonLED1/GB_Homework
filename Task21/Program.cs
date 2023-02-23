// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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