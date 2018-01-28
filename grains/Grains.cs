using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64) 
        {
            throw new ArgumentOutOfRangeException("N must be between 1 & 64");
        }
        return (ulong) Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        ulong total = 0;

        for (int i = 0; i <= 63; i++) 
        {
            total += (ulong) Math.Pow(2, i);
        }

        return total;
    }
}
