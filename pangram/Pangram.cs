using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToLower();
        
        for (char a = 'a'; a <= 'z'; a++) 
        {
            if (!input.Contains(a.ToString()))
            {
                return false;
            }
        }

        return true;
    }
}
