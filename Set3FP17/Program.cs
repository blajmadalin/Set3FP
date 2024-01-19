using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int nrschimbat = 0;
        int power = 1;
        while(n != 0)
        {
            int rest = n % b;
            n = n / b;
            nrschimbat = nrschimbat + rest * power;
            power = power * 10;
        }
        Console.WriteLine(nrschimbat);
    }
}