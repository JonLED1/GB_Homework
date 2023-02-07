Console.Clear();
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result=1;

for (int i=1; i<=b; i++)
    result=result * a;
Console.WriteLine($"A  в натуральной степени B = {result}");