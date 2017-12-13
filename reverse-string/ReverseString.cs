using System;
using System.Text;
using System.Collections;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        Stack inChars = new Stack();
        StringBuilder sb = new StringBuilder();

        if (String.IsNullOrEmpty(input))
        {
            return "";
        }

        for (int i = 0; i < input.Length; i++)
        {
            inChars.Push(input[i]);
        }

        while (inChars.Count != 0)
        {
            sb.Append(inChars.Pop());
        }

        return sb.ToString();
    }

}