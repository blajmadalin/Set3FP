using System;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[50];
        int n;
        int con = 0;
        int kon = 0;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
            if (v[i] == 0) kon++;
        }
        for(int i = 1; i <= n; i++)
        {
            if (v[i] == 0 && i <= n - kon + 1)
            {
                v[i] = v[n - con];
                v[n - con] = 0;
                con ++;
            }
        }
        Console.WriteLine(" ");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(v[i]);
        }
    }
}