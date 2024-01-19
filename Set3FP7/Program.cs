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
        for(int i = 1;i <= n / 2; i++)
        {
            int interchange = v[i];
            v[i] = v[n - i + 1];
            v[n - i + 1] = interchange;
        }
        for (int i = 1; i <= n ; i++) {
            Console.WriteLine(v[i]);
        }
    }
}