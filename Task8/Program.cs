Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int count=1;
Console.Write("Четные числа - ");
while (count <= n)
{
    if (count % 2 == 0) Console.Write($"{count}, ");
    count++;
}