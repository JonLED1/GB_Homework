//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow();
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result=1;

for (int i=1; i<=b; i++)
    result=result * a;
Console.WriteLine($"A  в натуральной степени B = {result}");