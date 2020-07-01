using System;
using System.Drawing;

// https://leetcode.com/problems/max-value-of-equation/

namespace _1499_Max_Value_of_Equation
{
    public class Solution
    {
        public int FindMaxValueOfEquation(int[][] points, int k)
        {
            int max = int.MinValue;

            for (int i=0; i < points.Length; ++i)
            {
                for (int j=i+1; j<points.Length; ++j)
                {
                    if (Math.Abs(points[j][0] - points[i][0]) > k) break;
                    if ((points[j][1] + points[i][1] + Math.Abs(points[j][0] - points[i][0])) > max)
                        max = points[j][1] + points[i][1] + Math.Abs(points[j][0] - points[i][0]);
                }
            }
            return max;
        }
    }
}
