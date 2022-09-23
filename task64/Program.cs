Console.Clear();
Console.WriteLine("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = int.Parse(Console.ReadLine());
if (m > n) Console.WriteLine("Значение первого элемента должно быть меньше значения второго!");
else
{
    int PrintNumbers(int m, int n)
    {
        if (m % 2 == 0 & m == n) return n;
        else if (m % 2 == 1 & m + 1 == n) return n;
        else if (n % 2 == 0) Console.WriteLine(n); return PrintNumbers(m, n - 1);
    }
    Console.WriteLine();
    Console.WriteLine(PrintNumbers(m, n));
}