using System;
using System.Text.RegularExpressions;

// Question is very poorly explained - "Whatever."

public static class Bob
{
    public static string Response(string statement)
    {
        char last = statement[statement.Length - 1];

        if (last.Equals('?'))
        {
            return "Sure.";
        }
        else if (Regex.Matches(statement, @"[a-zA-Z]").Count == 0)
        {
            return "Fine. Be that way!";
        }
        else if (statement.Equals(statement.ToUpper()))
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }
}