//3.2 Высокий уровень #15

Console.Write("Введите верхний предел: ");
double n = double.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
double m = double.Parse(Console.ReadLine());
double result = 0;
for (int i = 1; i <= n; i++)
{
    double value = 1;
    for (int j = 1; j <= m; j++)
    {
        value *= i;
    }
    result += value;
}
Console.WriteLine("Сумма чисел от 1 до {0}, возведенных в степень {1}, равна {2}", n, m, result);