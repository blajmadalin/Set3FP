using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[100];
        int n;
        int cmmdc;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
        }
        cmmdc = v[1];
        for(int i = 1; i < n; i++)
        {
            int a = cmmdc;
            int b = v[i + 1];
            int r = a % b;
            while(r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            cmmdc = a;

        }
        Console.WriteLine(cmmdc);  
    }
}