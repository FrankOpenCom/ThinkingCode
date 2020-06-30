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

            Dictionary<(long kn, long kd, long bn, long bd), HashSet<int>> space = new Dictionary<(long kn, long kd, long bn, long bd), HashSet<int>>();
            int maxPoints = 2;

            for (int f = 0; f<points.Length; ++f)
            {
                for (int s=f+1; s<points.Length; ++s)
                {
                    long kn = points[s][1] - points[f][1];
                    long kd = points[s][0] - points[f][0];
                    long bn = (points[s][0] - points[f][0]) * points[f][1] - (points[s][1] - points[f][1]) * points[f][0];
                    long bd = points[s][0] - points[f][0];

                    if (kd == 0 && bd == 0)
                    {
                        kd = points[s][0];
                        bd = kd;
                        kn = long.MaxValue;
                        bn = long.MaxValue;
                    }
                    else if (kn == 0)
                    {
                        kn = points[s][1];
                        bn = kn;
                        kd = long.MaxValue;
                        bd = long.MaxValue;
                    }

                    bool found = false;
                    foreach (KeyValuePair<(long kn, long kd, long bn, long bd), HashSet<int>> entry in space)
                    {
                        if ((kn == long.MaxValue && bn == long.MaxValue && entry.Key.kn == long.MaxValue && entry.Key.bn == long.MaxValue && kd == entry.Key.kd && bd == entry.Key.bd) || 
                            (kd == long.MaxValue && bd == long.MaxValue && entry.Key.kd == long.MaxValue && entry.Key.bd == long.MaxValue && kn == entry.Key.kn && bn == entry.Key.bn) ||
                            (kn * entry.Key.kd == kd * entry.Key.kn && bn * entry.Key.bd == bd * entry.Key.bn && kd != long.MaxValue && kn != long.MaxValue))
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
