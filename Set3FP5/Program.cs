using System;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[50];
        int n, e, k;
        n = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToInt32(Console.ReadLine());
        for(int i = 1;  i <= n; i ++)
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = n + 1;i >= k; i --) 
        {
            if (i != k)
            {
                v[i] = v[i - 1];
            }
            if (i == k)
            {
                v[i] = e;
            }
        }
        for (int i = 1; i <= n + 1; i++)
        {
            Console.WriteLine(v[i]);
        }

    }
}