using System;
using System.Collections.Generic;
​
public class Kata
{
    public static double FindArea(List<Point> points)
    {
        double res = 0;
        for (int i = 0; i < points.Count - 1; i++)
        {
            double x1 = points[i].X;
            double x2 = points[i+1].X;
            double y1 = points[i].Y;
            double y2 = points[i+1].Y;
​
            res += (y1 + y2) / 2 * (x2 - x1);
        }
        return res;
    }
}