using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SaddlePoints
{
    private int[,] matrix { get; set; }

    public SaddlePoints(int[,] values)
    {
        matrix = values;
    }

    public IEnumerable<Tuple<int, int>> Calculate()
    {
        List<Tuple<int, int>> points = new List<Tuple<int, int>>();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (IsSaddle(i, j))
                {
                    points.Add(new Tuple<int, int>(i, j));
                }
            }
        }
        return points;
    }

    private bool IsSaddle(int y, int x) 
    {
        // Search matrix horizontally
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix[y, i] > matrix[y, x])
            {
                return false;
            }
        }

        // Search matrix vertically
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix[i, x] < matrix[y, x])
            {
                return false;
            }
        }

        return true;
    }
}
