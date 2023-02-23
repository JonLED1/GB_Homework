// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double InputNumb(string x)
{
    Console.Write($"Веедите число {x} ");
    double n = Convert.ToDouble(Console.ReadLine());
    return n;
}

Console.Clear();
double b1 = InputNumb("b1");
double k1 = InputNumb("k1");
double b2 = InputNumb("b2");
double k2 = InputNumb("k2");

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
if (k1 == k2)
    Console.WriteLine("Заданные прямые не пересекаются");
else
    Console.WriteLine($"Точка пересечения - ({x};{y})");