using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[100];
        int[] b = new int[100];
        int[] c = new int[200];
        int n, m;
        int ok = 0;
        n = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());
        for (int k = 1; k <= n; k++)
        {
            a[k] = Convert.ToInt32(Console.ReadLine());
        }
        for (int k = 1; k <= m; k++)
        {
            b[k] = Convert.ToInt32(Console.ReadLine());
        }
        int i = 1, j = 1, z = 1;
        while (i <= n && j <= m)
        {
            if (a[i] > b[j])
            {
                c[z] = b[j];
                z++;
                j++;
            }
            else
            {
                c[z] = a[i];
                z++;
                i++;
            }
        }
        while(i <= n)
        {
            c[z] = a[i];
            i++;
            z++;
        }
        while(j <= m)
        {
            c[z] = b[i];
            j++;
            z++;
        }
        for(int k = 1; k <= z - 1;k++) {
            Console.Write(c[k]);
            Console.Write(' ');
        }
    }
}