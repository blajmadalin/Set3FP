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

        for(int i = 1;i < n; i++) 
        {
            for (int j = i + 1; j <= n; j++)
            {
                if (v[j] < v[i])
                {
                    int aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                }
            }
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(v[i]);
        }
    }
}