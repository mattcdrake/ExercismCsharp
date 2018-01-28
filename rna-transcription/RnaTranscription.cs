using System;
using System.Text;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        StringBuilder rna = new StringBuilder("");

        foreach (char item in nucleotide)
        {
            switch (item)
            {
                case 'G':
                    rna.Append("C");
                    break;
                case 'C':
                    rna.Append("G");
                    break;
                case 'T':
                    rna.Append("A");
                    break;
                case 'A':
                    rna.Append("U");
                    break;                
                default:
                    break;
            }
        }
        return rna.ToString();
    }
}