using System;
using System.Text.RegularExpressions;

// Question is very poorly explained - "Whatever."

public static class Bob
{
    public static string Response(string statement)
    {
        string statement_trim = statement.Trim();
        char last = statement_trim.Equals("") ? ' ' : statement_trim[statement_trim.Length - 1];

        if (last.Equals('?') && statement.Equals(statement.ToUpper())
            && Regex.Matches(statement, @"[a-zA-Z]").Count != 0)
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (last.Equals('?'))
        {
            return "Sure.";
        }
        else if (statement_trim.Equals(""))
        {
            return "Fine. Be that way!";
        }
        else if (statement.Equals(statement.ToUpper()) && Regex.Matches(statement, @"[a-zA-Z]").Count != 0)
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }
}