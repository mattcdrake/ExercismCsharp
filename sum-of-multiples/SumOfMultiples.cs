using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        bool flagVal;

        for (int curr = 0; curr < max; curr++)
        {
            flagVal = false;

            foreach (int e in multiples)
            {
                if (curr % e == 0)
                {
                    flagVal = true;
                }
            }

            if (flagVal)
            {
                sum += curr;
            }
        }

        return sum;
    }
}