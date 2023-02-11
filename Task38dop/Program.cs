Console.Clear();
Console.Write("Введите длину массива от 1 до 100: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 100)
{
    Console.WriteLine("Длина массива вне диапазона!");
    Console.WriteLine("Введите длину массива от 1 до 100: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 32);
Console.WriteLine($"Массив: [{string.Join(" ", array)}]");

int countEven = 0;
int countOdd = 0;

Console.Write("Нечет - ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2!=0)
    {
        Console.Write($"{array[i]} ");
        countOdd++;
    }
}

Console.Write("\nЧет - ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
    {
        Console.Write($"{array[i]} ");
        countEven++;
    }
    
}

if (countEven>countOdd) Console.WriteLine("\nYES - четверка!");
else Console.WriteLine("\nNO - тройка!");