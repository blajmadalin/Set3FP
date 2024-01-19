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
        int p = 0;
        for (int i = 1; i <= n; i++)
        {
            p = i;
            while (p > 0 && v[p] < v[p - 1])
            {
                int aux = v[p - 1];
                v[p - 1] = v[p];
                v[p] = aux;
            }
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(v[i]);
        }
    }
}