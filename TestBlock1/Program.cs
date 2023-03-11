void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"Введите элемент массива № {i} - ");
        array[i] = Console.ReadLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
InputArray(array);
Console.WriteLine("Исходный массив");
Console.WriteLine($"[{string.Join(", ",array)}]");

