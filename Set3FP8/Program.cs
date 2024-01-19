using System;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[50];
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
        }
        int first = v[1];
        int last = v[n];
        for (int i = 2; i <= n; i++)
        {
            v[i - 1] = v[i];
        }
        v[n] = first;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(v[i]);
        }
    }
}