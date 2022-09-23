Console.Clear();
Console.WriteLine("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = int.Parse(Console.ReadLine());
int FindNOD(int n, int m)
{
    n = Math.Abs(n);
    m = Math.Abs(m);
    if (n == m) return n;
    int min = n > m ? m : n;
    if (min <= 1) return min;
    int max = n > m ? n : m;
    int temp = max % min;
    if (temp == 0) return min;
    return FindNOD(temp, min);
}
Console.WriteLine($"Наибольший общий делитель {n} и {m} = " + FindNOD(n, m));