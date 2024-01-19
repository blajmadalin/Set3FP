using System;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[50];
        int n, minn = 1, maxx = -1, minAparitii = 0, maxAparitii = 0;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            v[i] = Convert.ToInt32(Console.ReadLine());
            if (v[i] < minn)
            {
                minn = v[i];
                minAparitii = 1;
            }
            if (v[i] == minn) 
            {
                minAparitii++;
            }
            if (v[i] == maxx)
            {
                maxAparitii++;
            }
            if (v[i] > maxx)
            {
                maxx = v[i];    
                maxAparitii = 1;
            }
        }
        Console.WriteLine(minAparitii);
        Console.WriteLine(maxAparitii);
    }
}