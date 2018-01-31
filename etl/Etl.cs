using System;
using System.Collections.Generic;

public static class Etl
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {
        Dictionary<string, int> afterDict = new Dictionary<string, int>(); 

        foreach(var item in old) 
        {
            foreach (var oldLetter in item.Value)
            {
                afterDict.Add(oldLetter.ToLower(), item.Key);
            }
        }

        return afterDict;
    }
}