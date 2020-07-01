using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

// https://leetcode.com/problems/max-value-of-equation/

namespace _1499_Max_Value_of_Equation
{
    public class Solution
    {
        public class ByDiffAndIndex : IComparer<(int diff, int i)>
        {
            public int Compare((int diff, int i) x, (int diff, int i) y)
            {
                int vExt = x.diff.CompareTo(y.diff);
                if (vExt != 0)
                {
                    return vExt;
                }
                else
                {
                    return x.i.CompareTo(y.i);
                }
            }
        }

        public int FindMaxValueOfEquation(int[][] points, int k)
        {
            int max = int.MinValue;

            SortedSet<(int diff, int i)> priorities = new SortedSet<(int diff, int i)>(new ByDiffAndIndex());

            priorities.Add((points[0][1] - points[0][0], points[0][0]));

            for (int j = 1; j < points.Length; ++j)
            {
                while (priorities.Count > 0)
                {
                    (int diff, int i) m = priorities.Max;
                    if ((points[j][0] - m.i) > k) priorities.Remove(m);
                    else break;
                }

                if (priorities.Count > 0)
                {
                    int tMax = priorities.Max.diff + points[j][0] + points[j][1];
                    if (tMax > max) max = tMax;
                }

                priorities.Add((points[j][1] - points[j][0], points[j][0]));
            }

            return max;
        }
    }
}


/*
            int max = int.MinValue;

            for (int i=0; i < points.Length;++i)
            {
                for (int j=i+1; j<points.Length; ++j)
                {
                    if (Math.Abs(points[j][0] - points[i][0]) > k) break;
                    if ((points[j][1] + points[i][1] + Math.Abs(points[j][0] - points[i][0])) > max)
                    {
                        max = points[j][1] + points[i][1] + Math.Abs(points[j][0] - points[i][0]);
                    }
                }
                
            }
            return max; 
*/
