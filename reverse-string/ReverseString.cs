using System;
using System.Text;
using System.Collections;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        StringBuilder sb = new StringBuilder();

        if (String.IsNullOrEmpty(input))
        {
            return "";
        }

        for (int i = 0; i < input.Length; i++)
        {
            sb.Insert(0, input[i]);
        }

        return sb.ToString();
    }

}