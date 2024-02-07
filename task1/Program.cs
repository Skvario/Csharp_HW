using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 5;
        int n = 10;

        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }
}