using System;

class Program
{
    public static void Quick(int[] a, int st, int dr)
    {
        int pivot = a[st];
        int d = 2;
        int i = st;
        int j = dr;
        while(st < dr)
        {
            if (a[i] < a[pivot])
            {
                int aux = a[d];
                a[d] = a[i];
                a[i] = aux;
                d++;
            }
            i++;
        }
    }

    static void Main(string[] args)
    {
        int[] a = new int[100];
        int n = Convert.ToInt32(Console.ReadLine);
        for (int i = 1; i <= n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Quick(a, n);
       
    }
}