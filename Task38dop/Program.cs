﻿// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть,
//  чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки,
// а по четным – четверки. Так же он помнит, в какие дни он получал эти оценки.
//   Поэтому он выписал на бумажке все эти дни для того, чтобы оценить, сколько у него троек и сколько четверок.
// Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек. 


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