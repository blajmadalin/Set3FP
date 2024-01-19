using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[100];
        int[] b = new int[100];
        int n, m;
        int ok = 0;
        n = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());
        for (int k = 1; k <= n; k ++)
        {
            a[k] = Convert.ToInt32(Console.ReadLine());
        }
        for (int k = 1; k <= m; k++)
        {
            b[k] = Convert.ToInt32(Console.ReadLine());
        }
        int i = 1;
        while(ok == 0)
        {
            if (a[i] > b[i])
            {
                ok = 1;
            }
            i++;
        }
        if (ok == 0) Console.WriteLine("Primul sir este mai mic lexicografic?");
        else Console.WriteLine("Al doilea este");
    }
}