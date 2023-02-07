Console.Clear();
Console.WriteLine("Введите количество элементов массива не более 1000");
int n=Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 1000)
{
    Console.Write("Не более 1000!!!\nВведите количество элементов массива ");
    n = Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[n];

Console.WriteLine("Введите элементы массива ");
int element=0;
for (int i=0; i<n; i++)
{
    element=Convert.ToInt32(Console.ReadLine());
    while (element < 1 || element > 1000)
    {
        Console.Write("Н более 1000!!!\nВведите элементы массива ");
        element = Convert.ToInt32(Console.ReadLine());
    }
    array[i]=element;
}

Console.WriteLine("Введите искомое число не более 1000");
int num=Convert.ToInt32(Console.ReadLine());
while (num < 1 || num > 1000)
{
    Console.Write("Не более 1000!!!\nВведите искомое число не более 1000 ");
    num = Convert.ToInt32(Console.ReadLine());
}
// можно проверку на 1000 сделать функцией, но умничать не стал. пока на семинарах не разбирали.

int count=0;
for (int i=0; i<array.Length; i++)
{
    if (array[i]==num)
        count++;
}
Console.WriteLine($"В массиве [{string.Join(" ", array)}] число - {num} встречается {count} раз(а).");

