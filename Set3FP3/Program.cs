using System;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[50];
        int n, minn, maxx;
        n =Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++) 
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
        }
        minn = 1;
        maxx = n;
        for(int i = 1; i <= n; i++)
        {
            if (v[i] < minn) minn = i;
            if (v[i] > maxx) maxx = i;
        }
        Console.WriteLine(minn);
        Console.WriteLine(maxx);
    }
}