int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    {
        if (n == 0 && m > 0)
        {
            return Ackerman(m - 1, 1);
        }
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}
Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackerman(m, n));