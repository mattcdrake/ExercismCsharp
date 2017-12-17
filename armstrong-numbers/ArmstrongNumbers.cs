using System;
using System.Collections.Generic;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        List<int> digits = new List<int>();
        int working_num = number;

        while (working_num >= 10)
        {
            digits.Add(working_num % 10);
            working_num /= 10;
        }

        digits.Add(working_num);

        int actual = 0;

        foreach(int i in digits)
        {
            actual += (int) Math.Pow(i, digits.Count);
        }

        return (actual == number);
    }
}