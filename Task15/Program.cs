Console.Clear();
Console.Write("Введите день недели (число от 1 до 7) ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Таких дней недели не бывает!\nВведите день недели (число от 1 до 7) ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n==7 || n==6)
    Console.WriteLine($"{n} -> Выходной");
else
    Console.WriteLine($"{n} -> Не выходной");