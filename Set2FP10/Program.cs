using System;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[50];
        int n, k;
        n = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        int st = 1;
        int dr = n;
        int apare = 0;
        int mij = (st + dr) / 2;
        while(st <= dr && apare == 0)
        {
            mij = (st + dr) / 2;
            if (k == v[mij]) apare = mij;
            else
            {
                if (v[mij] < k)
                {
                    dr = mij - 1;
                }
                else
                {
                    st = mij + 1;
                }

            }
        }
        Console.WriteLine(apare);
    }
}