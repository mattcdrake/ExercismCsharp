using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string output = "";

        if ((3 <= number) && (number % 3 == 0))
        {
            output += "Pling";
        }
        if ((5 <= number) && (number % 5 == 0))
        {
            output += "Plang";
        }
        if ((7 <= number) && (number % 7 == 0))
        {
            output += "Plong";
        }
        if (output.Equals(""))
        {
            output = number.ToString();
        }

        return output;
    }
}