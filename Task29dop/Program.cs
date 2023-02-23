Console.Clear();
Console.WriteLine("Введите количество элементов массива не более 10000");
int n=Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 10000)
{
    Console.Write("Не более 10000!!!\nВведите количество элементов массива ");
    n = Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[n];

Console.WriteLine("Введите элементы массива, не более 100 ");
int element=0;
for (int i=0; i<n; i++)
{
    element=Convert.ToInt32(Console.ReadLine());
    while (element > 100)
    {
        Console.Write("Не более 100!!!\nВведите элементы массива ");
        element = Convert.ToInt32(Console.ReadLine());
    }
    array[i]=element;
}

// Дана последовательность из N целых чисел и число K.
//  Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, 
//  если K – положительное и влево, если отрицательное. 

Console.WriteLine($"Введите число сдвига не более 100000");
int num=Convert.ToInt32(Console.ReadLine());
while (num > 10000)
{
    Console.Write("Не более 1000!!!\nВведите число сдвига не более 100000 ");
    num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Был массив [{string.Join(" ", array)}]");

if (num>0)
{
    for (int nn=1; nn<=num; nn++)
    {
        int temp=array[array.Length-1];
        for (int i=array.Length-1; i>0; i--)
            array[i]=array[i-1];
        array[0]=temp;
    }
}
else
{
    for (int nn=1; nn<=Math.Abs(num); nn++)
    {
        int temp=array[0];
        for (int i=0; i<array.Length-1; i++)
            array[i]=array[i+1];
        array[array.Length-1]=temp;
    }  
}
Console.WriteLine($"Стал массив [{string.Join(" ", array)}]");
