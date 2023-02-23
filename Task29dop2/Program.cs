// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, 
// причём таких разложений может быть несколько. Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.

// Требуется написать программу, производящую согласно утверждению Гольдбаха,
// разложение заданного чётного числа. Из всех пар простых чисел, сумма которых равна заданному числу, 
// требуется найти пару, содержащую наименьшее простое число. 

Console.Clear();
Console.WriteLine("Введите четное число больше 3 и меньше 999");
int n=Convert.ToInt32(Console.ReadLine());
while (n < 4 || n > 998 || n%2==1)
{
    Console.Write("Не пойдет!!! ");
    n = Convert.ToInt32(Console.ReadLine());
}

//делаем список простых чисел в диапазоне 2...n. разиер массива оказывается нельзя менять после объявления. так как неизвестно сколько чисел простых найдем применил лист.
List<int> sim = new List<int>();
int count=0;
for (int i=0; i<=n; i++)
    {
    for (int ii=2; ii<=n; ii++)
        if (i%ii==0) count++;
    if (count==1)
        sim.Add(i);
    count=0;
    }

//ищем пары равную сумме числа n
List<int> summ = new List<int>();
for (int i=0; i<sim.Count; i++)
    {
        for (int ii=0; ii<sim.Count; ii++) 
            if (n==sim[i]+sim[ii])
            {
                summ.Add(sim[i]);
                summ.Add(sim[ii]);
            }
    }
    
//ищем пару с наименьшим простым числом
int min1=summ[0];
int min2=summ[1];
for (int i=0; i<summ.Count-1; i=i+2)
    if (summ[i]<min1 || summ[i+1]<min2)
    {
        min1=summ[i];
        min2=summ[i+1];
    }
if (min1<min2) Console.WriteLine($"{min1} {min2}");
else Console.WriteLine($"{min2} {min1}");