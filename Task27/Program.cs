Console.Clear();
Console.WriteLine("Введите число ");
string? a = Console.ReadLine();
int result=0;
for (int i=0; i<a.Length; i++)
    result = result + Convert.ToInt32(a[i].ToString());
Console.WriteLine($"Сумма чисел в числе {a} = {result}");
