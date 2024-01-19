using System;

class Program
{
    static void Main(string[] args)
    {
        int[] ciur = new int[1000];
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (ciur[i] == 0)
            {
                for(int j = 2 * i; j <= n; j++)
                {
                    ciur[j] = 1;
                }
            }
        }
        for(int i = 2;  i <= n; i++)
        {
            if(ciur[i] == 0)
            {
                Console.WriteLine(i);
            }
        }

        
        Console.WriteLine(apare);
    }
}