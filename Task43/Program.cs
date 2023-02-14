int InputNumb(string x)
{
    Console.Write($"Веедите число {x} ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

Console.Clear();
float b1=InputNumb("b1");
float k1=InputNumb("k1");
float b2=InputNumb("b2");
float k2=InputNumb("k2");

float x = (b2-b1)/(k1-k2);
float y = k1*(b2-b1)/(k1-k2)+b1;
if (k1==k2)
    Console.WriteLine("Заданные прямые не пересекаются");
else
    Console.WriteLine($"Точка пересечения - ({x};{y})");