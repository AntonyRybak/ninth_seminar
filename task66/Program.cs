Console.Clear();
Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine());
int PrintNumbers(int n, int m)
{
    if (n == m) return m;
    else return PrintNumbers(n, m - 1) + m;
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел в промежуте от {n} до {m} равна: {PrintNumbers(n, m)}");