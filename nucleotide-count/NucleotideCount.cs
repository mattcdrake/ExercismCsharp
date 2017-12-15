using System;
using System.Linq;
using System.Collections.Generic;

public class NucleotideCount
{
    private Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {'A', 0 },
            {'C', 0 },
            {'G', 0 },
            {'T', 0 }
        };

    public NucleotideCount(string sequence)
    {
        foreach (char c in sequence)
        {
            if (!dict.ContainsKey(c))
            {
                throw new InvalidNucleotideException();
            }
            else
            {
                dict[c]++;
            }
        }
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return dict;
        }
    }
}

public class InvalidNucleotideException : Exception { }
