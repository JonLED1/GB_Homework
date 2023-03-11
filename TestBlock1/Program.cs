void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива № {i} - ");
        array[i] = Console.ReadLine()!;
    }
}

string[] ModArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length < 4) count++;
    string[] modarray= new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            modarray[count] = array[i];
            count++;
        }
    }
return modarray;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
InputArray(array);
Console.WriteLine("Исходный массив");
Console.WriteLine($"[{string.Join(", ", array)}]");
ModArray(array);
Console.WriteLine("Модифицированный массив");
Console.WriteLine($"[{string.Join(", ", ModArray(array))}]");
