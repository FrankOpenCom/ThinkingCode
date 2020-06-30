using System;
using System.Collections.Generic;
using System.Data;
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

            Dictionary<(int kn, int kd, int bn, int bd), HashSet<int>> space = new Dictionary<(int kn, int kd, int bn, int bd), HashSet<int>>();
            int maxPoints = 2;

            for (int f = 0; f<points.Length; ++f)
            {
                for (int s=f+1; s<points.Length; ++s)
                {
                    int kn = points[s][1] - points[f][1];
                    int kd = points[s][0] - points[f][0];
                    int bn = (points[s][0] - points[f][0]) * points[f][1] - (points[s][1] - points[f][1]) * points[f][0];
                    int bd = points[s][0] - points[f][0];

                    if (kd == 0 && bd == 0)
                    {
                        kd = points[s][0];
                        bd = kd;
                        kn = 0;
                        bn = 0;
                    }
                    else if (kn == 0)
                    {
                        kn = points[s][1];
                        bn = kn;
                        kd = 0;
                        kn = 0;
                    }

                    bool found = false;
                    foreach (KeyValuePair<(int kn, int kd, int bn, int bd), HashSet<int>> entry in space)
                    {
                        if ((kn == 0 && entry.Key.kn == 0 && kd == entry.Key.kd) || 
                            (kd == 0 && entry.Key.kd == 0 && kn == entry.Key.kn) ||
                            (kn * entry.Key.kd == kd * entry.Key.kn && bn * entry.Key.bd == bd * entry.Key.bn))
                        {
                            entry.Value.Add(f);
                            entry.Value.Add(s);
                            if (entry.Value.Count > maxPoints) maxPoints = entry.Value.Count;
                            found = true;
                            break;
                        }
                    }


                    if (!found)
                    {
                        space[(kn, kd, bn, bd)] = new HashSet<int>() {f, s};
                    }
                }
            }

            return maxPoints;
        }
    }
}
