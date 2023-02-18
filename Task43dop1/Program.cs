int InputNumb(string x)
{
    Console.Write($"Веедите координату {x} ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

Console.Clear();
int x1 = InputNumb("x1");
int y1 = InputNumb("y1");
int x2 = InputNumb("x2");
int y2 = InputNumb("y2");
int x3 = InputNumb("x3");
int y3 = InputNumb("y3");

double SqTriang = Math.Abs(0.5 * ((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)));
Console.WriteLine($"Площадь треугольника {SqTriang}");
