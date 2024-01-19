using System;

class Program
{
    static void Main(string[] args)
    {
        double[] v = new double[100];
        int n = Convert.ToInt32(Console.ReadLine());
        double x = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i <= n; ++i)
        {
            sum = sum + v[i] * Math.Pow(x, i);
        }
        Console.WriteLine(sum);
    }
}