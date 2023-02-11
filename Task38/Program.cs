Console.Clear();
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);

int max = array[0];
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
        max = array[i];
    if (min > array[i])
        min = array[i];
}
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"max: {max}");
Console.WriteLine($"min: {min}");
Console.WriteLine($"Разница между max и min: {max-min}");