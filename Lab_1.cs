using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите X");
        int x = Convert.ToInt32(Console.ReadLine());
        double res = 0;

        for (int n = 0; n <= N; n++)
        {
            res += (Math.Pow(-1, n) * (Math.Pow(x, 2 * n)) / Factorial(n));

            Console.WriteLine(Factorial(n));
        }
        Console.WriteLine(res);
    }

    public static double Factorial(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;

    }
}
