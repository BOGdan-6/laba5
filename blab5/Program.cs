
    const double E = 0.001;
    Console.Write("Введите значение x=");
    double x = double.Parse(Console.ReadLine());
    double S = 0;
    int n = 0;
    double a = x / 3;
    do
    {
        S = S + a;
        n++;
        a *= (n + 1) / (Math.Pow(3, n / 2.0) * n);
    }
    while (a >= E);
    Console.WriteLine($"Сумма S= {S}");
Console.ReadLine();