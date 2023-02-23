//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);

int sum=0;
for (int i = 1; i < array.Length; i=i+2)
    sum=sum+array[i];
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");