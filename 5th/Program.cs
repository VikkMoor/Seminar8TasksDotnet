float Factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++) x *= i;
    return x;
}

int i, n, c;
Console.Write("Enter count of rows of triangle: ");
n = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++) Console.Write(" ");
    for (c = 0; c <= i; c++)
    {
        Console.Write("  ");
        Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
    }
    Console.WriteLine();
    Console.WriteLine();
}

