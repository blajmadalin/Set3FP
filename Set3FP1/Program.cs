using System;

class Program
{
    static void Main(string[] args)
    {
        string text;
        text = Console.ReadLine();
        string[] numbers = text.Split(" ");
        int[] sir = new int[numbers.Length];
        int suma = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            sir[i] = int.Parse(numbers[i]);
            suma = suma + sir[i];
        }
        Console.WriteLine(suma);
    }
}