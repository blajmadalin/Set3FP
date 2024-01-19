using System;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[100];
        int n;
        int ok = 0;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine(ok);
        for (int i = 1; i <= n - ok; i++)
        {
            Console.WriteLine(v[i]);
        }
    }
}