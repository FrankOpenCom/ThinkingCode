using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/max-points-on-a-line/

namespace _149_Max_Points_on_a_Line
{
    public class Solution
    {
        public int MaxPoints(int[][] points)
        {
            if (points.Length <= 2) return points.Length;

            Dictionary<(float k, float b), HashSet<(int x, int y)>> space = new Dictionary<(float k, float b), HashSet<(int x, int y)>>();
            int maxPoints = 2;

            for (int f = 0; f<points.Length; ++f)
            {
                for (int s=f+1; s<points.Length; ++s)
                {
                    // y = kx + b
                    float k = float.NaN;
                    float b = float.NaN;
                    if (points[f][0] != points[s][0])
                    {
                        k = (points[f][1] - points[s][1]) / (points[f][0] - points[s][0]);
                        b = points[f][1] - k * points[f][0];
                    }
                    else b = points[f][0];

                    if (!space.ContainsKey((k, b)))
                    {
                        space[(k, b)] = new HashSet<(int x, int y)>();
                    }

                    space[(k, b)].Add((points[f][0], points[f][1]));
                    space[(k, b)].Add((points[s][0], points[s][1]));
                    if (space[(k, b)].Count > maxPoints) maxPoints = space[(k, b)].Count;
                }
            }

            return maxPoints;
        }
    }
}
